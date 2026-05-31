using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Formats;

namespace ImageContextMenuConverter
{
    public partial class MainForm : Form
    {
        private string? _inputFilePath;
        private SixLabors.ImageSharp.Image? _currentImage;
        private System.Windows.Forms.Timer _estimateTimer;

        public MainForm(string? filePath = null)
        {
            InitializeComponent();
            _inputFilePath = filePath;

            _estimateTimer = new System.Windows.Forms.Timer();
            _estimateTimer.Interval = 500;
            _estimateTimer.Tick += EstimateTimer_Tick;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            UpdateRegistryButtonText();
            
            cmbFormat.Items.AddRange(new string[] { "JPEG", "PNG", "BMP", "GIF", "WebP" });
            cmbFormat.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(_inputFilePath))
            {
                await LoadImageAsync(_inputFilePath);
            }
            else
            {
                btnSelectFile.Visible = true;
            }
        }

        private async Task LoadImageAsync(string path)
        {
            try
            {
                _inputFilePath = path;
                _currentImage = await SixLabors.ImageSharp.Image.LoadAsync(path);
                lblFileInfo.Text = $"Файл: {Path.GetFileName(path)}\nРазмер: {_currentImage.Width}x{_currentImage.Height}";

                // Заполняем доп. поля
                txtOutputName.Text = Path.GetFileNameWithoutExtension(path) + "_converted";
                txtOutputPath.Text = Path.GetDirectoryName(path) ?? "";

                // Рассчитываем оригинальное соотношение (целыми числами)
                lblOriginalRatio.Text = $"Ориг. соотн.: {SimplifyRatio(_currentImage.Width, _currentImage.Height)}";

                txtWidth.Text = _currentImage.Width.ToString();
                txtHeight.Text = _currentImage.Height.ToString();
                btnConvert.Enabled = true;
                UpdateNewRatio();
                StartEstimation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadImageAsync(ofd.FileName);
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (_currentImage == null || string.IsNullOrEmpty(_inputFilePath)) return;

            try
            {
                int width = int.Parse(txtWidth.Text);
                int height = int.Parse(txtHeight.Text);

                using (var processedImage = _currentImage.Clone(x => x.Resize(width, height)))
                {
                    string format = cmbFormat.SelectedItem?.ToString()?.ToLower() ?? "jpeg";
                    string extension = format switch
                    {
                        "jpeg" => ".jpg",
                        "png" => ".png",
                        "bmp" => ".bmp",
                        "gif" => ".gif",
                        "webp" => ".webp",
                        _ => ".jpg"
                    };

                    string outputDir = txtOutputPath.Text;
                    string fileName = txtOutputName.Text;
                    
                    if (!fileName.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
                    {
                        fileName += extension;
                    }

                    string outputPath = Path.Combine(outputDir, fileName);

                    IImageEncoder encoder = GetEncoder(format, trackQuality.Value);

                    processedImage.Save(outputPath, encoder);
                    MessageBox.Show($"Изображение сохранено:\n{outputPath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при конвертации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            pnlAdvanced.Visible = !pnlAdvanced.Visible;
            btnAdvanced.Text = pnlAdvanced.Visible ? "Дополнительно ▲" : "Дополнительно ▼";
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnToggleRegistry_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegistryManager.IsRegistered())
                {
                    RegistryManager.Unregister();
                }
                else
                {
                    RegistryManager.Register();
                }
                UpdateRegistryButtonText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка реестра: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRegistryButtonText()
        {
            btnToggleRegistry.Text = RegistryManager.IsRegistered() 
                ? "Удалить из контекстного меню" 
                : "Добавить в контекстное меню";
        }

        private void chkKeepAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeepAspectRatio.Checked && _currentImage != null && int.TryParse(txtWidth.Text, out int width))
            {
                double ratio = (double)_currentImage.Height / _currentImage.Width;
                txtHeight.Text = ((int)(width * ratio)).ToString();
            }
        }

        private bool _isUpdatingDimensions = false;

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdatingDimensions) return;

            if (chkKeepAspectRatio.Checked && _currentImage != null && int.TryParse(txtWidth.Text, out int width) && width > 0)
            {
                _isUpdatingDimensions = true;
                double ratio = (double)_currentImage.Height / _currentImage.Width;
                txtHeight.Text = ((int)(width * ratio)).ToString();
                _isUpdatingDimensions = false;
            }
            UpdateNewRatio();
            StartEstimation();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdatingDimensions) return;

            if (chkKeepAspectRatio.Checked && _currentImage != null && int.TryParse(txtHeight.Text, out int height) && height > 0)
            {
                _isUpdatingDimensions = true;
                double ratio = (double)_currentImage.Width / _currentImage.Height;
                txtWidth.Text = ((int)(height * ratio)).ToString();
                _isUpdatingDimensions = false;
            }
            UpdateNewRatio();
            StartEstimation();
        }

        private void UpdateNewRatio()
        {
            if (int.TryParse(txtWidth.Text, out int w) && int.TryParse(txtHeight.Text, out int h) && h > 0)
            {
                lblNewRatio.Text = $"Новое соотн.: {SimplifyRatio(w, h)}";
            }
            else
            {
                lblNewRatio.Text = "Новое соотн.: -";
            }
        }

        private string SimplifyRatio(int width, int height)
        {
            if (width <= 0 || height <= 0) return "-";
            
            double target = (double)width / height;
            double minError = 0.02; // Допуск 2%
            
            // Пробуем найти простую дробь с малым знаменателем (до 50)
            for (int d = 1; d <= 50; d++)
            {
                int n = (int)Math.Round(target * d);
                if (n > 0 && Math.Abs(target - (double)n / d) < minError)
                {
                    return $"{n}:{d}";
                }
            }
            
            // Если не нашли простую, возвращаем точное сокращенное значение
            int common = GCD(width, height);
            return $"{width / common}:{height / common}";
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartEstimation();
        }

        private void trackQuality_Scroll(object sender, EventArgs e)
        {
            numQuality.Value = trackQuality.Value;
            StartEstimation();
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {
            trackQuality.Value = (int)numQuality.Value;
            StartEstimation();
        }

        private void StartEstimation()
        {
            if (_currentImage == null) return;
            _estimateTimer.Stop();
            _estimateTimer.Start();
            lblEstimatedSize.Text = "Ожидаемый размер: расчет...";
        }

        private async void EstimateTimer_Tick(object sender, EventArgs e)
        {
            _estimateTimer.Stop();
            await UpdateEstimatedSizeAsync();
        }

        private async Task UpdateEstimatedSizeAsync()
        {
            if (_currentImage == null) return;

            try
            {
                if (!int.TryParse(txtWidth.Text, out int width) || !int.TryParse(txtHeight.Text, out int height) || width <= 0 || height <= 0)
                {
                    lblEstimatedSize.Text = "Ожидаемый размер: некорректный размер";
                    return;
                }

                string format = cmbFormat.SelectedItem?.ToString()?.ToLower() ?? "jpeg";
                IImageEncoder encoder = GetEncoder(format, trackQuality.Value);

                long sizeInBytes = await Task.Run(() =>
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cloned = _currentImage.Clone(x => x.Resize(width, height)))
                        {
                            cloned.Save(ms, encoder);
                            return ms.Length;
                        }
                    }
                });

                lblEstimatedSize.Text = $"Ожидаемый размер: {FormatSize(sizeInBytes)}";
            }
            catch
            {
                lblEstimatedSize.Text = "Ожидаемый размер: ошибка расчета";
            }
        }

        private IImageEncoder GetEncoder(string format, int quality)
        {
            return format switch
            {
                "jpeg" => new JpegEncoder { Quality = quality },
                "png" => new PngEncoder(),
                "bmp" => new BmpEncoder(),
                "gif" => new GifEncoder(),
                "webp" => new WebpEncoder { Quality = quality },
                _ => new JpegEncoder { Quality = quality }
            };
        }

        private string FormatSize(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB" };
            int counter = 0;
            decimal number = bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }
    }
}
