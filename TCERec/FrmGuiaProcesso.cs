using BLLTCERec;
using DALTCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCERec
{
    public partial class FrmGuiaProcesso : Form
    {
        Int32 conferidos = 0;
        Int32 intProcessado = 0;
        Guia GuiaSelecionada;

        public FrmGuiaProcesso()
        {
            InitializeComponent();
        }

        private void FrmGuiaProcesso_Load(object sender, EventArgs e)
        {
            txtGuia.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirma Devolução da Guia?", "Confirmação", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    BLLTCERec.BLLGuia.DevolverGuia(txtGuia.Text);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtGuia_TextChanged(object sender, EventArgs e)
        {
            CarregarProcessosGuia();

        }

        private void CarregarProcessosGuia()
        {
            try
            {
                List<Processo> dt = BLLTCERec.BLLProcesso.CarregarProcessos(txtGuia.Text);

                BLLGuia bGuia = new BLLGuia();
                Guia g = bGuia.CarregarGuia(txtGuia.Text);

                var newList = dt.Select(x => new
                {
                    x.NProcesso,
                    x.DigProcesso,
                    x.AnoProcesso,
                    x.Processado,
                    x.Digitalizado,
                    x.Devolvido,
                    x.PastaDestino,
                    x.SeqGuia
                }).ToList();

                GuiaSelecionada = g;

                dtgProcessoConfere.DataSource = newList;

                if (newList.Count > 0) { txtProcesso.Focus(); }

                lblOrgao.Text = "Orgão Origem " + g.DestinoGuia + " Orgão Destino " + g.DestinoGuia;

                lblOrgao.Visible = true;

                intProcessado = dt.Count;
                lblProcessosConferidos.Text = "Processos Encaminhados " + intProcessado + " / " + conferidos;
                lblProcessosConferidos.Visible = true;

                dtgProcessoConfere.Enabled = true;
                ConferirProcessos(false);


            }
            catch (Exception ex)
            {

            }

        }


        private void dtgProcessoConfere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProcessosConferidos_Click(object sender, EventArgs e)
        {

        }


        private void lblProcessosEncaminhados_Click(object sender, EventArgs e)
        {

        }

        private void lblOrgao_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgProcessoConfere_CellStyleContentChanged(object sender, DataGridViewCellStyleContentChangedEventArgs e)
        {

        }

        private void dtgProcessoConfere_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ConferirProcessos(true);
        }

        private void dtgProcessoConfere_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 13)
            {
                MarcarConferido(e);
            }

            if (e.ColumnIndex == 15)
            {
                DititalizarGrid(e);
            }


            if (e.ColumnIndex == 19)
            {
                AbrirPasta(e);
            }

        }

        private void AbrirPasta(DataGridViewCellEventArgs e)
        {
            if (dtgProcessoConfere.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != null)
            {
                ProcessStartInfo StartInformation = new ProcessStartInfo();
                StartInformation.FileName = dtgProcessoConfere.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                Process process = Process.Start(StartInformation);
                //process.EnableRaisingEvents = true;
            }
        }

        private void DititalizarGrid(DataGridViewCellEventArgs e)
        {
            if (dtgProcessoConfere.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                BLLProcesso bLL = new BLLProcesso();
                if (dtgProcessoConfere.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dtgProcessoConfere.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    conferidos = conferidos + 1;
                    Processo p = CarregarProcesso(dtgProcessoConfere.Rows[e.RowIndex]);
                    p.PastaDestino = CriarPastas(p);
                    bLL.DigitalizarProcesso(p);

                }


                CarregarProcessosGuia();
                ConferirProcessos(false);

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MarcarDigitalizadoProcessos();
        }


        private void MarcarConferidoBarcode(Processo pp)
        {

            DataGridViewRow r = new DataGridViewRow();

            foreach (DataGridViewRow l in dtgProcessoConfere.Rows)
            {
                Processo pv = CarregarProcesso(l);

                if (pv.NProcesso == pp.NProcesso && pv.AnoProcesso == pp.AnoProcesso && pv.DigProcesso == pp.DigProcesso)
                    r = l;

            }

            if (r.Index < 0) return;

            BLLProcesso bLL = new BLLProcesso();
            Processo p = CarregarProcesso(dtgProcessoConfere.Rows[r.Index]);
            bLL.ConferirProcesso(p);
            CarregarProcessosGuia();
            ConferirProcessos(false);
        }




        private void MarcarConferido(DataGridViewCellEventArgs e)
        {
            BLLProcesso bLL = new BLLProcesso();
            if (dtgProcessoConfere.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                Processo p = CarregarProcesso(dtgProcessoConfere.Rows[e.RowIndex]);
                bLL.ConferirProcesso(p);
            }


            CarregarProcessosGuia();
            ConferirProcessos(false);
        }


        private void ConferirProcessos(bool atualiza)
        {

            BLLProcesso bLL = new BLLProcesso();
            conferidos = 0;
            foreach (DataGridViewRow r in dtgProcessoConfere.Rows)
            {

                if (r.Cells[13].Value != null)

                {
                    if ((bool)r.Cells[13].Value == true)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                        conferidos = conferidos + 1;
                    }
                }

                if (r.Cells[15].Value != null)

                {

                    if ((bool)r.Cells[15].Value == true)
                    {
                        r.DefaultCellStyle.BackColor = Color.Green;

                    }
                }

                lblProcessosConferidos.Text = "Processos Encaminhados " + intProcessado + " / " + conferidos;
            }
        }


        private void MarcarDigitalizadoProcessos()
        {
            BLLProcesso bLL = new BLLProcesso();
            conferidos = 0;
            foreach (DataGridViewRow r in dtgProcessoConfere.Rows)
            {

                if (r.Cells[13].Value != null)


                    if ((bool)r.Cells["Digitalizado"].Value == true)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                        conferidos = conferidos + 1;
                        Processo p = CarregarProcesso(r);

                        p.PastaDestino = CriarPastas(p);
                        bLL.DigitalizarProcesso(p);


                    }


                lblProcessosConferidos.Text = "Processos Digitalizados " + intProcessado + " / " + conferidos;
            }
        }


        private Processo CarregarProcesso(DataGridViewRow r)
        {
            var p = new Processo();
            var selectedRow = r;
            Int16 np;
            p.NProcesso = r.Cells[3].Value.ToString();
            p.DigProcesso = r.Cells[4].Value.ToString();
            Int16.TryParse(r.Cells[5].Value.ToString(), out np);
            p.AnoProcesso = np;
            p.NumeroGuia = GuiaSelecionada.NumeroGuia;
            p.SeqGuia = GuiaSelecionada.SeqGuia;
            p.AnoGuia = GuiaSelecionada.AnoGuia;
            p.DestinoGuia = GuiaSelecionada.DestinoGuia;
            return p;
        }

        private string CriarPastas(Processo p)

        {
            string ano = p.AnoGuia.ToString().PadRight(2);
            string anop = p.AnoProcesso.ToString().PadRight(2);
            string seq = p.SeqGuia.ToString().PadRight(2);

            string caminho = txtCaminho.Text + '\\' + p.DestinoGuia + '\\' + p.NumeroGuia + '_' + ano + '\\' + p.NProcesso + p.DigProcesso;

            if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
            return caminho;

        }

        private void txtProcesso_TextChanged(object sender, EventArgs e)
        {

            if (txtProcesso.Text.Split('/').Last().Length < 4 || !txtProcesso.Text.Contains('/')) return;
            Processo p = new Processo();
            p.NProcesso = txtProcesso.Text.Split('-').First();
            p.DigProcesso = txtProcesso.Text.Split('-').Last().Split('/').First();
            p.AnoProcesso = Int16.Parse(txtProcesso.Text.Split('/').Last());
            MarcarConferidoBarcode(p);
            txtProcesso.Text = string.Empty;

        }
    }


}

