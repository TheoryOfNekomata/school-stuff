using System;
using System.Windows.Forms;

namespace PointTracer {
    static class Program {
        public static Arguments Arguments { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Arguments = new Arguments(args);
            Application.Run(new PointTracer());
        }
    }
}
