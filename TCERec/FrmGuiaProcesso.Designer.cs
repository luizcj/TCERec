namespace TCERec
{
    partial class FrmGuiaProcesso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tCEREDXDataSet = new TCERec.TCEREDXDataSet();
            this.tDummyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDummyTableAdapter = new TCERec.TCEREDXDataSetTableAdapters.TDummyTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConferido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblProcessosEncaminhados = new System.Windows.Forms.Label();
            this.lblProcessosConferidos = new System.Windows.Forms.Label();
            this.btnDevolverGuia = new System.Windows.Forms.Button();
            this.lxlOrgao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tCEREDXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDummyBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(47, 6);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(141, 20);
            this.txtGuia.TabIndex = 0;
            this.txtGuia.TextChanged += new System.EventHandler(this.txtGuia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tCEREDXDataSet
            // 
            this.tCEREDXDataSet.DataSetName = "TCEREDXDataSet";
            this.tCEREDXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDummyBindingSource
            // 
            this.tDummyBindingSource.DataMember = "TDummy";
            this.tDummyBindingSource.DataSource = this.tCEREDXDataSet;
            // 
            // tDummyTableAdapter
            // 
            this.tDummyTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 257);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conferir Processos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nProcesso,
            this.Ano,
            this.cConferido});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // nProcesso
            // 
            this.nProcesso.HeaderText = "No. do Processo";
            this.nProcesso.Name = "nProcesso";
            this.nProcesso.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // cConferido
            // 
            this.cConferido.HeaderText = "Conferido";
            this.cConferido.Name = "cConferido";
            this.cConferido.ReadOnly = true;
            this.cConferido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cConferido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digitalizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(880, 225);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No. do Processo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Digitalizar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblProcessosEncaminhados
            // 
            this.lblProcessosEncaminhados.AutoSize = true;
            this.lblProcessosEncaminhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessosEncaminhados.Location = new System.Drawing.Point(420, 60);
            this.lblProcessosEncaminhados.Name = "lblProcessosEncaminhados";
            this.lblProcessosEncaminhados.Size = new System.Drawing.Size(240, 20);
            this.lblProcessosEncaminhados.TabIndex = 3;
            this.lblProcessosEncaminhados.Text = "Processos Encaminhados 10";
            // 
            // lblProcessosConferidos
            // 
            this.lblProcessosConferidos.AutoSize = true;
            this.lblProcessosConferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessosConferidos.Location = new System.Drawing.Point(666, 60);
            this.lblProcessosConferidos.Name = "lblProcessosConferidos";
            this.lblProcessosConferidos.Size = new System.Drawing.Size(189, 20);
            this.lblProcessosConferidos.TabIndex = 4;
            this.lblProcessosConferidos.Text = "Processos Conferidos ";
            // 
            // btnDevolverGuia
            // 
            this.btnDevolverGuia.Location = new System.Drawing.Point(61, 32);
            this.btnDevolverGuia.Name = "btnDevolverGuia";
            this.btnDevolverGuia.Size = new System.Drawing.Size(98, 23);
            this.btnDevolverGuia.TabIndex = 5;
            this.btnDevolverGuia.Text = "Devolver Guia";
            this.btnDevolverGuia.UseVisualStyleBackColor = true;
            this.btnDevolverGuia.Click += new System.EventHandler(this.button1_Click);
            // 
            // lxlOrgao
            // 
            this.lxlOrgao.AutoSize = true;
            this.lxlOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lxlOrgao.Location = new System.Drawing.Point(481, 26);
            this.lxlOrgao.Name = "lxlOrgao";
            this.lxlOrgao.Size = new System.Drawing.Size(331, 20);
            this.lxlOrgao.TabIndex = 6;
            this.lxlOrgao.Text = "Orgão Origem ____ Orgão Destino ____";
            // 
            // FrmGuiaProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 330);
            this.Controls.Add(this.lxlOrgao);
            this.Controls.Add(this.btnDevolverGuia);
            this.Controls.Add(this.lblProcessosConferidos);
            this.Controls.Add(this.lblProcessosEncaminhados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuia);
            this.Name = "FrmGuiaProcesso";
            this.Text = "Importar Guia e Processo";
            this.Load += new System.EventHandler(this.FrmGuiaProcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCEREDXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDummyBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label1;
        private TCEREDXDataSet tCEREDXDataSet;
        private System.Windows.Forms.BindingSource tDummyBindingSource;
        private TCEREDXDataSetTableAdapters.TDummyTableAdapter tDummyTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cConferido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblProcessosEncaminhados;
        private System.Windows.Forms.Label lblProcessosConferidos;
        private System.Windows.Forms.Button btnDevolverGuia;
        private System.Windows.Forms.Label lxlOrgao;
    }
}

