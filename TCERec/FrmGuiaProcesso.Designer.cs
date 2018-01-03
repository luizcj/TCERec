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
            this.tDummyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgProcessoConfere = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblProcessosEncaminhados = new System.Windows.Forms.Label();
            this.lblProcessosConferidos = new System.Windows.Forms.Label();
            this.btnDevolverGuia = new System.Windows.Forms.Button();
            this.lblOrgao = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PastaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastaAbrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.origemGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqGuiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processoFilhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitoProcessoFilhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoProcessoFilhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqProcessoFiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.devolvidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.digitalizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.erroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImportacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProcesso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tDummyBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcessoConfere)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 357);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgProcessoConfere);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conferir Processos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgProcessoConfere
            // 
            this.dtgProcessoConfere.AllowUserToAddRows = false;
            this.dtgProcessoConfere.AllowUserToDeleteRows = false;
            this.dtgProcessoConfere.AutoGenerateColumns = false;
            this.dtgProcessoConfere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProcessoConfere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origemGuiaDataGridViewTextBoxColumn,
            this.numeroGuiaDataGridViewTextBoxColumn,
            this.anoGuiaDataGridViewTextBoxColumn,
            this.nProcessoDataGridViewTextBoxColumn,
            this.digProcessoDataGridViewTextBoxColumn,
            this.anoProcessoDataGridViewTextBoxColumn,
            this.destinoGuiaDataGridViewTextBoxColumn,
            this.dataGuiaDataGridViewTextBoxColumn,
            this.seqGuiaDataGridViewTextBoxColumn,
            this.processoFilhoDataGridViewTextBoxColumn,
            this.digitoProcessoFilhoDataGridViewTextBoxColumn,
            this.anoProcessoFilhoDataGridViewTextBoxColumn,
            this.seqProcessoFiloDataGridViewTextBoxColumn,
            this.processadoDataGridViewTextBoxColumn,
            this.devolvidoDataGridViewTextBoxColumn,
            this.digitalizadoDataGridViewTextBoxColumn,
            this.erroDataGridViewTextBoxColumn,
            this.dataImportacaoDataGridViewTextBoxColumn,
            this.PastaDestino,
            this.PastaAbrir});
            this.dtgProcessoConfere.DataSource = this.processoBindingSource;
            this.dtgProcessoConfere.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProcessoConfere.Location = new System.Drawing.Point(3, 6);
            this.dtgProcessoConfere.Name = "dtgProcessoConfere";
            this.dtgProcessoConfere.Size = new System.Drawing.Size(877, 322);
            this.dtgProcessoConfere.TabIndex = 0;
            this.dtgProcessoConfere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProcessoConfere_CellContentClick_1);
            this.dtgProcessoConfere.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProcessoConfere_CellEndEdit);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digitalizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView1.DataSource = this.processoBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 322);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // lblProcessosEncaminhados
            // 
            this.lblProcessosEncaminhados.AutoSize = true;
            this.lblProcessosEncaminhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessosEncaminhados.Location = new System.Drawing.Point(257, 60);
            this.lblProcessosEncaminhados.Name = "lblProcessosEncaminhados";
            this.lblProcessosEncaminhados.Size = new System.Drawing.Size(240, 20);
            this.lblProcessosEncaminhados.TabIndex = 3;
            this.lblProcessosEncaminhados.Text = "Processos Encaminhados 10";
            this.lblProcessosEncaminhados.Visible = false;
            this.lblProcessosEncaminhados.Click += new System.EventHandler(this.lblProcessosEncaminhados_Click);
            // 
            // lblProcessosConferidos
            // 
            this.lblProcessosConferidos.AutoSize = true;
            this.lblProcessosConferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessosConferidos.Location = new System.Drawing.Point(503, 60);
            this.lblProcessosConferidos.Name = "lblProcessosConferidos";
            this.lblProcessosConferidos.Size = new System.Drawing.Size(189, 20);
            this.lblProcessosConferidos.TabIndex = 4;
            this.lblProcessosConferidos.Text = "Processos Conferidos ";
            this.lblProcessosConferidos.Visible = false;
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
            // lblOrgao
            // 
            this.lblOrgao.AutoSize = true;
            this.lblOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgao.Location = new System.Drawing.Point(318, 26);
            this.lblOrgao.Name = "lblOrgao";
            this.lblOrgao.Size = new System.Drawing.Size(71, 20);
            this.lblOrgao.TabIndex = 6;
            this.lblOrgao.Text = " Origem";
            this.lblOrgao.Visible = false;
            this.lblOrgao.Click += new System.EventHandler(this.lblOrgao_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TCERec.Properties.Settings.Default, "Caminho", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Location = new System.Drawing.Point(676, 85);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(206, 20);
            this.txtCaminho.TabIndex = 7;
            this.txtCaminho.Text = global::TCERec.Properties.Settings.Default.Caminho;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino:";
            // 
            // PastaDestino
            // 
            this.PastaDestino.DataPropertyName = "PastaDestino";
            this.PastaDestino.HeaderText = "Pasta Destino";
            this.PastaDestino.Name = "PastaDestino";
            this.PastaDestino.Width = 180;
            // 
            // PastaAbrir
            // 
            this.PastaAbrir.HeaderText = "Abrir";
            this.PastaAbrir.Name = "PastaAbrir";
            this.PastaAbrir.Width = 30;
            // 
            // origemGuiaDataGridViewTextBoxColumn
            // 
            this.origemGuiaDataGridViewTextBoxColumn.DataPropertyName = "OrigemGuia";
            this.origemGuiaDataGridViewTextBoxColumn.HeaderText = "OrigemGuia";
            this.origemGuiaDataGridViewTextBoxColumn.Name = "origemGuiaDataGridViewTextBoxColumn";
            this.origemGuiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroGuiaDataGridViewTextBoxColumn
            // 
            this.numeroGuiaDataGridViewTextBoxColumn.DataPropertyName = "NumeroGuia";
            this.numeroGuiaDataGridViewTextBoxColumn.HeaderText = "NumeroGuia";
            this.numeroGuiaDataGridViewTextBoxColumn.Name = "numeroGuiaDataGridViewTextBoxColumn";
            this.numeroGuiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // anoGuiaDataGridViewTextBoxColumn
            // 
            this.anoGuiaDataGridViewTextBoxColumn.DataPropertyName = "AnoGuia";
            this.anoGuiaDataGridViewTextBoxColumn.HeaderText = "AnoGuia";
            this.anoGuiaDataGridViewTextBoxColumn.Name = "anoGuiaDataGridViewTextBoxColumn";
            this.anoGuiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nProcessoDataGridViewTextBoxColumn
            // 
            this.nProcessoDataGridViewTextBoxColumn.DataPropertyName = "NProcesso";
            this.nProcessoDataGridViewTextBoxColumn.HeaderText = "Número";
            this.nProcessoDataGridViewTextBoxColumn.Name = "nProcessoDataGridViewTextBoxColumn";
            // 
            // digProcessoDataGridViewTextBoxColumn
            // 
            this.digProcessoDataGridViewTextBoxColumn.DataPropertyName = "DigProcesso";
            this.digProcessoDataGridViewTextBoxColumn.HeaderText = "Digito";
            this.digProcessoDataGridViewTextBoxColumn.Name = "digProcessoDataGridViewTextBoxColumn";
            // 
            // anoProcessoDataGridViewTextBoxColumn
            // 
            this.anoProcessoDataGridViewTextBoxColumn.DataPropertyName = "AnoProcesso";
            this.anoProcessoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoProcessoDataGridViewTextBoxColumn.Name = "anoProcessoDataGridViewTextBoxColumn";
            // 
            // destinoGuiaDataGridViewTextBoxColumn
            // 
            this.destinoGuiaDataGridViewTextBoxColumn.DataPropertyName = "DestinoGuia";
            this.destinoGuiaDataGridViewTextBoxColumn.HeaderText = "DestinoGuia";
            this.destinoGuiaDataGridViewTextBoxColumn.Name = "destinoGuiaDataGridViewTextBoxColumn";
            this.destinoGuiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGuiaDataGridViewTextBoxColumn
            // 
            this.dataGuiaDataGridViewTextBoxColumn.DataPropertyName = "DataGuia";
            this.dataGuiaDataGridViewTextBoxColumn.HeaderText = "DataGuia";
            this.dataGuiaDataGridViewTextBoxColumn.Name = "dataGuiaDataGridViewTextBoxColumn";
            this.dataGuiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // seqGuiaDataGridViewTextBoxColumn
            // 
            this.seqGuiaDataGridViewTextBoxColumn.DataPropertyName = "SeqGuia";
            this.seqGuiaDataGridViewTextBoxColumn.HeaderText = "Sequencia";
            this.seqGuiaDataGridViewTextBoxColumn.Name = "seqGuiaDataGridViewTextBoxColumn";
            // 
            // processoFilhoDataGridViewTextBoxColumn
            // 
            this.processoFilhoDataGridViewTextBoxColumn.DataPropertyName = "ProcessoFilho";
            this.processoFilhoDataGridViewTextBoxColumn.HeaderText = "ProcessoFilho";
            this.processoFilhoDataGridViewTextBoxColumn.Name = "processoFilhoDataGridViewTextBoxColumn";
            this.processoFilhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // digitoProcessoFilhoDataGridViewTextBoxColumn
            // 
            this.digitoProcessoFilhoDataGridViewTextBoxColumn.DataPropertyName = "DigitoProcessoFilho";
            this.digitoProcessoFilhoDataGridViewTextBoxColumn.HeaderText = "DigitoProcessoFilho";
            this.digitoProcessoFilhoDataGridViewTextBoxColumn.Name = "digitoProcessoFilhoDataGridViewTextBoxColumn";
            this.digitoProcessoFilhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // anoProcessoFilhoDataGridViewTextBoxColumn
            // 
            this.anoProcessoFilhoDataGridViewTextBoxColumn.DataPropertyName = "AnoProcessoFilho";
            this.anoProcessoFilhoDataGridViewTextBoxColumn.HeaderText = "AnoProcessoFilho";
            this.anoProcessoFilhoDataGridViewTextBoxColumn.Name = "anoProcessoFilhoDataGridViewTextBoxColumn";
            this.anoProcessoFilhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // seqProcessoFiloDataGridViewTextBoxColumn
            // 
            this.seqProcessoFiloDataGridViewTextBoxColumn.DataPropertyName = "SeqProcessoFilo";
            this.seqProcessoFiloDataGridViewTextBoxColumn.HeaderText = "SeqProcessoFilo";
            this.seqProcessoFiloDataGridViewTextBoxColumn.Name = "seqProcessoFiloDataGridViewTextBoxColumn";
            this.seqProcessoFiloDataGridViewTextBoxColumn.Visible = false;
            // 
            // processadoDataGridViewTextBoxColumn
            // 
            this.processadoDataGridViewTextBoxColumn.DataPropertyName = "Processado";
            this.processadoDataGridViewTextBoxColumn.HeaderText = "Conferido";
            this.processadoDataGridViewTextBoxColumn.Name = "processadoDataGridViewTextBoxColumn";
            this.processadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.processadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // devolvidoDataGridViewTextBoxColumn
            // 
            this.devolvidoDataGridViewTextBoxColumn.DataPropertyName = "Devolvido";
            this.devolvidoDataGridViewTextBoxColumn.HeaderText = "Devolvido";
            this.devolvidoDataGridViewTextBoxColumn.Name = "devolvidoDataGridViewTextBoxColumn";
            this.devolvidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.devolvidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // digitalizadoDataGridViewTextBoxColumn
            // 
            this.digitalizadoDataGridViewTextBoxColumn.DataPropertyName = "Digitalizado";
            this.digitalizadoDataGridViewTextBoxColumn.HeaderText = "Digitalizado";
            this.digitalizadoDataGridViewTextBoxColumn.Name = "digitalizadoDataGridViewTextBoxColumn";
            this.digitalizadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.digitalizadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // erroDataGridViewTextBoxColumn
            // 
            this.erroDataGridViewTextBoxColumn.DataPropertyName = "Erro";
            this.erroDataGridViewTextBoxColumn.HeaderText = "Erro";
            this.erroDataGridViewTextBoxColumn.Name = "erroDataGridViewTextBoxColumn";
            this.erroDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataImportacaoDataGridViewTextBoxColumn
            // 
            this.dataImportacaoDataGridViewTextBoxColumn.DataPropertyName = "DataImportacao";
            this.dataImportacaoDataGridViewTextBoxColumn.HeaderText = "DataImportacao";
            this.dataImportacaoDataGridViewTextBoxColumn.Name = "dataImportacaoDataGridViewTextBoxColumn";
            this.dataImportacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // processoBindingSource
            // 
            this.processoBindingSource.DataSource = typeof(DALTCE.Processo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrigemGuia";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrigemGuia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumeroGuia";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumeroGuia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnoGuia";
            this.dataGridViewTextBoxColumn3.HeaderText = "AnoGuia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NProcesso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DigProcesso";
            this.dataGridViewTextBoxColumn5.HeaderText = "Digito";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnoProcesso";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DestinoGuia";
            this.dataGridViewTextBoxColumn7.HeaderText = "DestinoGuia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataGuia";
            this.dataGridViewTextBoxColumn8.HeaderText = "DataGuia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SeqGuia";
            this.dataGridViewTextBoxColumn9.HeaderText = "SeqGuia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProcessoFilho";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProcessoFilho";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DigitoProcessoFilho";
            this.dataGridViewTextBoxColumn11.HeaderText = "DigitoProcessoFilho";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AnoProcessoFilho";
            this.dataGridViewTextBoxColumn12.HeaderText = "AnoProcessoFilho";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SeqProcessoFilo";
            this.dataGridViewTextBoxColumn13.HeaderText = "SeqProcessoFilo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Processado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Conferido";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Devolvido";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Devolvido";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Digitalizado";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Digitalizado";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Erro";
            this.dataGridViewTextBoxColumn14.HeaderText = "Erro";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DataImportacao";
            this.dataGridViewTextBoxColumn15.HeaderText = "DataImportacao";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // txtProcesso
            // 
            this.txtProcesso.Location = new System.Drawing.Point(59, 112);
            this.txtProcesso.Name = "txtProcesso";
            this.txtProcesso.Size = new System.Drawing.Size(100, 20);
            this.txtProcesso.TabIndex = 9;
            this.txtProcesso.TextChanged += new System.EventHandler(this.txtProcesso_TextChanged);
            // 
            // FrmGuiaProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.lblOrgao);
            this.Controls.Add(this.btnDevolverGuia);
            this.Controls.Add(this.lblProcessosConferidos);
            this.Controls.Add(this.lblProcessosEncaminhados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.txtProcesso);
            this.Name = "FrmGuiaProcesso";
            this.Text = "Importar Guia e Processo";
            this.Load += new System.EventHandler(this.FrmGuiaProcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDummyBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcessoConfere)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource tDummyBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgProcessoConfere;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblProcessosEncaminhados;
        private System.Windows.Forms.Label lblProcessosConferidos;
        private System.Windows.Forms.Button btnDevolverGuia;
        private System.Windows.Forms.Label lblOrgao;
        private System.Windows.Forms.BindingSource processoBindingSource;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqGuiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processoFilhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digitoProcessoFilhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoProcessoFilhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqProcessoFiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn processadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn devolvidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn digitalizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn erroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImportacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastaDestino;
        private System.Windows.Forms.DataGridViewButtonColumn PastaAbrir;
        private System.Windows.Forms.TextBox txtProcesso;
    }
}

