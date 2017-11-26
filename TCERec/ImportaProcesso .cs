using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLTCERec;
namespace TCERec
{
    public partial class ImportaProcesso : Form
    {
        public ImportaProcesso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtNomeArquivo.Text = openFileDialog1.FileName;
            btnImportar.Enabled = true;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLTDummy seq = new BLLTDummy();
                seq.Importar(txtNomeArquivo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Importar, verifique se o arquivo já não foi importado");

            }
        }
    }
}
