namespace ImageContextMenuConverter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pnlFormat = new System.Windows.Forms.Panel();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.pnlDimensions = new System.Windows.Forms.Panel();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblOriginalRatio = new System.Windows.Forms.Label();
            this.lblNewRatio = new System.Windows.Forms.Label();
            this.chkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.pnlQualityHeader = new System.Windows.Forms.Panel();
            this.lblQuality = new System.Windows.Forms.Label();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.trackQuality = new System.Windows.Forms.TrackBar();
            this.lblEstimatedSize = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnToggleRegistry = new System.Windows.Forms.Button();
            
            this.flowLayoutPanelMain.SuspendLayout();
            this.pnlFormat.SuspendLayout();
            this.pnlDimensions.SuspendLayout();
            this.pnlQualityHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackQuality)).BeginInit();
            this.pnlAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelMain.Controls.Add(this.lblFileInfo);
            this.flowLayoutPanelMain.Controls.Add(this.btnSelectFile);
            this.flowLayoutPanelMain.Controls.Add(this.pnlFormat);
            this.flowLayoutPanelMain.Controls.Add(this.pnlDimensions);
            this.flowLayoutPanelMain.Controls.Add(this.chkKeepAspectRatio);
            this.flowLayoutPanelMain.Controls.Add(this.pnlQualityHeader);
            this.flowLayoutPanelMain.Controls.Add(this.trackQuality);
            this.flowLayoutPanelMain.Controls.Add(this.lblEstimatedSize);
            this.flowLayoutPanelMain.Controls.Add(this.btnConvert);
            this.flowLayoutPanelMain.Controls.Add(this.btnAdvanced);
            this.flowLayoutPanelMain.Controls.Add(this.pnlAdvanced);
            this.flowLayoutPanelMain.Controls.Add(this.btnToggleRegistry);
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(360, 500);
            this.flowLayoutPanelMain.TabIndex = 0;
            this.flowLayoutPanelMain.WrapContents = false;
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(18, 15);
            this.lblFileInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblFileInfo.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(150, 15);
            this.lblFileInfo.TabIndex = 0;
            this.lblFileInfo.Text = "Изображение не выбрано";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(18, 43);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(120, 25);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Выбрать файл...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Visible = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // pnlFormat
            // 
            this.pnlFormat.Controls.Add(this.lblFormat);
            this.pnlFormat.Controls.Add(this.cmbFormat);
            this.pnlFormat.Location = new System.Drawing.Point(18, 81);
            this.pnlFormat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(320, 50);
            this.pnlFormat.TabIndex = 2;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(0, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(107, 15);
            this.lblFormat.Text = "Целевой формат:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.Location = new System.Drawing.Point(0, 20);
            this.cmbFormat.Size = new System.Drawing.Size(120, 23);
            this.cmbFormat.TabIndex = 0;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // pnlDimensions
            // 
            this.pnlDimensions.Controls.Add(this.lblWidth);
            this.pnlDimensions.Controls.Add(this.txtWidth);
            this.pnlDimensions.Controls.Add(this.lblHeight);
            this.pnlDimensions.Controls.Add(this.txtHeight);
            this.pnlDimensions.Controls.Add(this.lblOriginalRatio);
            this.pnlDimensions.Controls.Add(this.lblNewRatio);
            this.pnlDimensions.Location = new System.Drawing.Point(18, 144);
            this.pnlDimensions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.pnlDimensions.Name = "pnlDimensions";
            this.pnlDimensions.Size = new System.Drawing.Size(320, 50);
            this.pnlDimensions.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.Location = new System.Drawing.Point(0, 0);
            this.lblWidth.Size = new System.Drawing.Size(70, 15);
            this.lblWidth.Text = "Ширина:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(0, 20);
            this.txtWidth.Size = new System.Drawing.Size(70, 23);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(85, 0);
            this.lblHeight.Size = new System.Drawing.Size(70, 15);
            this.lblHeight.Text = "Высота:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(85, 20);
            this.txtHeight.Size = new System.Drawing.Size(70, 23);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblOriginalRatio
            // 
            this.lblOriginalRatio.AutoSize = true;
            this.lblOriginalRatio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblOriginalRatio.Location = new System.Drawing.Point(170, 5);
            this.lblOriginalRatio.Text = "Ориг. соотн.: -";
            // 
            // lblNewRatio
            // 
            this.lblNewRatio.AutoSize = true;
            this.lblNewRatio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblNewRatio.Location = new System.Drawing.Point(170, 25);
            this.lblNewRatio.Text = "Новое соотн.: -";
            // 
            // chkKeepAspectRatio
            // 
            this.chkKeepAspectRatio.AutoSize = true;
            this.chkKeepAspectRatio.Checked = true;
            this.chkKeepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepAspectRatio.Location = new System.Drawing.Point(18, 202);
            this.chkKeepAspectRatio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.chkKeepAspectRatio.Size = new System.Drawing.Size(161, 19);
            this.chkKeepAspectRatio.Text = "Сохранять пропорции";
            this.chkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.chkKeepAspectRatio.CheckedChanged += new System.EventHandler(this.chkKeepAspectRatio_CheckedChanged);
            // 
            // pnlQualityHeader
            // 
            this.pnlQualityHeader.Controls.Add(this.lblQuality);
            this.pnlQualityHeader.Controls.Add(this.numQuality);
            this.pnlQualityHeader.Location = new System.Drawing.Point(18, 234);
            this.pnlQualityHeader.Size = new System.Drawing.Size(320, 25);
            this.pnlQualityHeader.TabIndex = 4;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(0, 5);
            this.lblQuality.Text = "Качество:";
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(75, 2);
            this.numQuality.Size = new System.Drawing.Size(55, 23);
            this.numQuality.Value = new decimal(new int[] { 85, 0, 0, 0 });
            this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // trackQuality
            // 
            this.trackQuality.Location = new System.Drawing.Point(18, 265);
            this.trackQuality.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.trackQuality.Maximum = 100;
            this.trackQuality.Size = new System.Drawing.Size(320, 45);
            this.trackQuality.Value = 85;
            this.trackQuality.Scroll += new System.EventHandler(this.trackQuality_Scroll);
            // 
            // lblEstimatedSize
            // 
            this.lblEstimatedSize.AutoSize = true;
            this.lblEstimatedSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEstimatedSize.Location = new System.Drawing.Point(18, 323);
            this.lblEstimatedSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lblEstimatedSize.Size = new System.Drawing.Size(150, 15);
            this.lblEstimatedSize.Text = "Ожидаемый размер: ...";
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvert.Location = new System.Drawing.Point(18, 351);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnConvert.Size = new System.Drawing.Size(320, 50);
            this.btnConvert.Text = "КОНВЕРТИРОВАТЬ И СОХРАНИТЬ";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(18, 414);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(320, 30);
            this.btnAdvanced.TabIndex = 17;
            this.btnAdvanced.Text = "Дополнительно ▼";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.Controls.Add(this.lblOutputName);
            this.pnlAdvanced.Controls.Add(this.txtOutputName);
            this.pnlAdvanced.Controls.Add(this.lblOutputPath);
            this.pnlAdvanced.Controls.Add(this.txtOutputPath);
            this.pnlAdvanced.Controls.Add(this.btnBrowseOutput);
            this.pnlAdvanced.Location = new System.Drawing.Point(18, 457);
            this.pnlAdvanced.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(320, 110);
            this.pnlAdvanced.TabIndex = 18;
            this.pnlAdvanced.Visible = false;
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(0, 0);
            this.lblOutputName.Text = "Название файла:";
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(0, 20);
            this.txtOutputName.Size = new System.Drawing.Size(310, 23);
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(0, 55);
            this.lblOutputPath.Text = "Папка сохранения:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(0, 75);
            this.txtOutputPath.Size = new System.Drawing.Size(225, 23);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(235, 74);
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseOutput.Text = "Обзор...";
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnToggleRegistry
            // 
            this.btnToggleRegistry.Location = new System.Drawing.Point(18, 580);
            this.btnToggleRegistry.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnToggleRegistry.Name = "btnToggleRegistry";
            this.btnToggleRegistry.Size = new System.Drawing.Size(320, 25);
            this.btnToggleRegistry.TabIndex = 12;
            this.btnToggleRegistry.Text = "Добавить в контекстное меню";
            this.btnToggleRegistry.UseVisualStyleBackColor = true;
            this.btnToggleRegistry.Click += new System.EventHandler(this.btnToggleRegistry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 650);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер изображений";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelMain.PerformLayout();
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            this.pnlDimensions.ResumeLayout(false);
            this.pnlDimensions.PerformLayout();
            this.pnlQualityHeader.ResumeLayout(false);
            this.pnlQualityHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackQuality)).EndInit();
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Panel pnlFormat;
        private System.Windows.Forms.Panel pnlDimensions;
        private System.Windows.Forms.Panel pnlQualityHeader;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.CheckBox chkKeepAspectRatio;
        private System.Windows.Forms.Label lblOriginalRatio;
        private System.Windows.Forms.Label lblNewRatio;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.TrackBar trackQuality;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnToggleRegistry;
        private System.Windows.Forms.Label lblEstimatedSize;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.Label lblOutputName;
    }
}
