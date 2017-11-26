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
    public partial class ImportaSequencial : Form
    {
        public ImportaSequencial()
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

            BLLSequencial seq = new BLLSequencial();
            seq.ImportarSeq(txtNomeArquivo.Text);
        }
    }
}
