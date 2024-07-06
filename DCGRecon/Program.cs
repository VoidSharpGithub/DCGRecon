using System.Threading;

namespace DCGRecon
{
    internal static class Program
    {
        // Mutex to control single instance
        private static Mutex mutex = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "DCG_Recon_Application";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // App is already running! Exiting the application
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Mainfrm());

            // Release the mutex
            mutex.ReleaseMutex();
        }
    }
}