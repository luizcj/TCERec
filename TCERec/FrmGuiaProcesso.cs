using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCERec
{
    public partial class FrmGuiaProcesso : Form
    {
        public FrmGuiaProcesso()
        {
            InitializeComponent();
        }

        private void FrmGuiaProcesso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tCEREDXDataSet.TDummy'. Você pode movê-la ou removê-la conforme necessário.
            this.tDummyTableAdapter.Fill(this.tCEREDXDataSet.TDummy);
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirma Devolução da Guia?", "Confirmação", MessageBoxButtons.YesNo);
        }
    }
}
