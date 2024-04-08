using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _307_Coursework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result;

            using (var LoginForm = new LoginForm())
                result = LoginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new Form1());
            }


        }
    }
}
