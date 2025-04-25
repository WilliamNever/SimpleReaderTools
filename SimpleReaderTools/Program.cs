using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace SimpleReaderTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            if ((args?.Length ?? 0) > 0)
            {
                if (CheckUniqueRunning(args))
                {
                    if (MessageBox.Show("This Application is in running.\r\nCreate another new Process?", 
                        "Info -", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                    {
                        Environment.Exit(0);
                        return;
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool CheckUniqueRunning(string[] args)
        {
            if (args.Any(x => "-unique".Equals(x, StringComparison.OrdinalIgnoreCase)
            || "-u".Equals(x, StringComparison.OrdinalIgnoreCase)))
            {
                var assemlyName = Assembly.GetExecutingAssembly().GetName().Name;
                var curretProcessId = Process.GetCurrentProcess().Id;
                var excutionList = Process.GetProcesses().Select(x => new { x.Id, x.ProcessName });
                return excutionList.
                    Any(
                    x => x.Id != curretProcessId
                    && (x.ProcessName ?? "").Equals(assemlyName, StringComparison.OrdinalIgnoreCase));
            }
            return false;
        }
    }
}