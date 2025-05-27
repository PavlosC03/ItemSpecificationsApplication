using ItemSpecifications.Common;       // for CSettings
using Lib.Common.System;            // for CMSSQLLocalDBInstanceLauncher

namespace WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Launch the local DB Instance
            CMSSQLLocalDBInstanceLauncher.Launch(CSettings.Instance.DBInstanceName);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CFormMain());
        }


    }
}