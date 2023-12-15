using System.Diagnostics;

namespace EZLauncher
{
    internal class MacLauncher : ILauncher
    {
        public void OpenUrl(string url)
        {
            try
            {
                Process.Start("open", url);
            }
            catch (Exception)
            {
            }
        }

        public void OpenUrlDebug(string url)
        {
            try
            {
                Process.Start("open", url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening URL: {ex.Message}");
                throw;
            }
        }
    }
}
