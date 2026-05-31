using Microsoft.Win32;
using System.Diagnostics;

namespace ImageContextMenuConverter
{
    public static class RegistryManager
    {
        private const string MenuName = "Конвертировать изображение";
        private const string ShellKeyPath = @"Software\Classes\SystemFileAssociations\image\shell\ImageConverter";

        public static void Register()
        {
            string exePath = Process.GetCurrentProcess().MainModule?.FileName ?? throw new Exception("Could not find executable path");
            
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(ShellKeyPath))
            {
                key.SetValue("", MenuName);
                using (RegistryKey commandKey = key.CreateSubKey("command"))
                {
                    commandKey.SetValue("", $"\"{exePath}\" \"%1\"");
                }
            }
        }

        public static void Unregister()
        {
            Registry.CurrentUser.DeleteSubKeyTree(ShellKeyPath, false);
        }

        public static bool IsRegistered()
        {
            using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(ShellKeyPath))
            {
                return key != null;
            }
        }
    }
}
