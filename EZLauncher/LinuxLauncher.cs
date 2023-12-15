using System.Diagnostics;

namespace EZLauncher
{
    internal class LinuxLauncher : ILauncher
    {
        public void OpenUrl(string url)
        {
            try
            {
                Process.Start("xdg-open", url);
            }
            catch (Exception)
            {
            }
        }

        public void OpenUrlDebug(string url)
        {
            try
            {
                Process.Start("xdg-open", url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening URL: {ex.Message}");
                throw;
            }
        }
    }
}
