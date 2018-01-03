using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCERec
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DateTime date = new DateTime(2018,01,10);

            if (DateTime.Now > date)
            {
                MessageBox.Show("Erro");
                Application.Exit();

            }
            Application.Run(new TCE_REC());
           
        }
    }
}
