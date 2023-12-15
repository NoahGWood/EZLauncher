namespace EZLauncher
{
    public static class EZLauncher
    {
        private static readonly ILauncher _launcher;
        public static bool Debug = false;
        static EZLauncher()
        {
            _launcher = CreatePlatformSpecificLauncher();
        }

        public static void Launch(string url)
        {
            if(Debug)
                _launcher.OpenUrlDebug(url);
            else
                _launcher.OpenUrl(url);
        }
        public static void Launch(string url, bool debug)
        {
            if(debug || Debug)
                _launcher.OpenUrlDebug(url);
            else 
                _launcher.OpenUrl(url);
        }

        private static ILauncher CreatePlatformSpecificLauncher()
        {
            #if NETCOREAPP
                return new WindowsLauncher();
            #elif __MAC__
                return new MacLauncher();
            #elif __LINUX__
                return new LinuxLauncher();
            #else
                throw new PlatformNotSupportedException("Platform not supported.");
            #endif
        }
    }
}
