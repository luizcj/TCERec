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
    public partial class TCE_REC : Form
    {
        private int childFormNumber = 0;
        
        public TCE_REC()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }


        private void TCE_REC_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                if (item.Name == "ImportaSequencial")
                {
                    item.Focus();
                    item.ResumeLayout();
                    return;
                }

            }
            Form childForm = new ImportaSequencial();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void scannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                if (item.Name == "FrmGuiaProcesso")
                {
                    item.Focus();
                    item.ResumeLayout();
                    return;
                }

            }
            Form childForm = new FrmGuiaProcesso();
            childForm.MdiParent = this;
            childForm.Show();
        }


    

        private void importarGuiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                if (item.Name == "ImportaProcesso")
                {
                    item.Focus();
                    item.ResumeLayout();
                    return;
                }

            }
            Form childForm = new ImportaProcesso();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
