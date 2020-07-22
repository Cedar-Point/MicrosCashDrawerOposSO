using System;
using System.Windows.Forms;

namespace MicrosCashDrawerOposTestApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            Application.Run(new Window());
        }
    }
}
