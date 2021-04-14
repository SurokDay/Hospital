using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            Form main = new Main();
            
            
           /* List<Form> FormList = new List<Form>();

            Form LogInForm = new LogInForm();

            FormList.Add(main);
            FormList.Add(LogInForm);*/



            Application.Run(main);

            //Application.Run(new Main());



        }
    }
}
