namespace iMage
{
    partial class Form1
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.ctmPictureBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuModoDimensionamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDimensionamentoNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDimensionamentoStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDimensionamentoAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDimensionamentoCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDimensionamentoZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.linkCaminho = new System.Windows.Forms.LinkLabel();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.labelModo = new System.Windows.Forms.Label();
            this.comboModo = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.linkResetar = new System.Windows.Forms.LinkLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProgressoFundo = new System.Windows.Forms.Panel();
            this.panelProgressoFrente = new System.Windows.Forms.Panel();
            this.checkAlterarAutomaticamente = new System.Windows.Forms.CheckBox();
            this.checkModificarOriginal = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupPersonalizar = new System.Windows.Forms.GroupBox();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.trackA = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.trackR = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupOpçõesEscalaCinza = new System.Windows.Forms.GroupBox();
            this.labelLuminosidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackLuminosidade = new System.Windows.Forms.TrackBar();
            this.checkLinhasVerticais = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelValidacao = new System.Windows.Forms.Label();
            this.trackValidacao = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupLinhas = new System.Windows.Forms.GroupBox();
            this.trackValorMaximo = new System.Windows.Forms.TrackBar();
            this.labelValorMaximo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.ctmPictureBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelProgressoFundo.SuspendLayout();
            this.groupPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            this.groupOpçõesEscalaCinza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackLuminosidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValidacao)).BeginInit();
            this.groupLinhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValorMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagem.BackColor = System.Drawing.Color.Transparent;
            this.picImagem.BackgroundImage = global::iMage.Properties.Resources.fundo;
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem.ContextMenuStrip = this.ctmPictureBox;
            this.picImagem.Location = new System.Drawing.Point(13, 37);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(337, 401);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // ctmPictureBox
            // 
            this.ctmPictureBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuModoDimensionamento});
            this.ctmPictureBox.Name = "ctmPictureBox";
            this.ctmPictureBox.Size = new System.Drawing.Size(223, 26);
            // 
            // MenuModoDimensionamento
            // 
            this.MenuModoDimensionamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDimensionamentoNormal,
            this.MenuDimensionamentoStretch,
            this.MenuDimensionamentoAuto,
            this.MenuDimensionamentoCenter,
            this.MenuDimensionamentoZoom});
            this.MenuModoDimensionamento.Name = "MenuModoDimensionamento";
            this.MenuModoDimensionamento.Size = new System.Drawing.Size(222, 22);
            this.MenuModoDimensionamento.Text = "Modo de dimensionamento";
            // 
            // MenuDimensionamentoNormal
            // 
            this.MenuDimensionamentoNormal.CheckOnClick = true;
            this.MenuDimensionamentoNormal.Name = "MenuDimensionamentoNormal";
            this.MenuDimensionamentoNormal.Size = new System.Drawing.Size(144, 22);
            this.MenuDimensionamentoNormal.Text = "Normal";
            this.MenuDimensionamentoNormal.Click += new System.EventHandler(this.MenusDimensionamento_CheckedChanged);
            // 
            // MenuDimensionamentoStretch
            // 
            this.MenuDimensionamentoStretch.Checked = true;
            this.MenuDimensionamentoStretch.CheckOnClick = true;
            this.MenuDimensionamentoStretch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuDimensionamentoStretch.Name = "MenuDimensionamentoStretch";
            this.MenuDimensionamentoStretch.Size = new System.Drawing.Size(144, 22);
            this.MenuDimensionamentoStretch.Text = "StretchImage";
            this.MenuDimensionamentoStretch.Click += new System.EventHandler(this.MenusDimensionamento_CheckedChanged);
            // 
            // MenuDimensionamentoAuto
            // 
            this.MenuDimensionamentoAuto.CheckOnClick = true;
            this.MenuDimensionamentoAuto.Name = "MenuDimensionamentoAuto";
            this.MenuDimensionamentoAuto.Size = new System.Drawing.Size(144, 22);
            this.MenuDimensionamentoAuto.Text = "AutoSize";
            this.MenuDimensionamentoAuto.Click += new System.EventHandler(this.MenusDimensionamento_CheckedChanged);
            // 
            // MenuDimensionamentoCenter
            // 
            this.MenuDimensionamentoCenter.CheckOnClick = true;
            this.MenuDimensionamentoCenter.Name = "MenuDimensionamentoCenter";
            this.MenuDimensionamentoCenter.Size = new System.Drawing.Size(144, 22);
            this.MenuDimensionamentoCenter.Text = "CenterImage";
            this.MenuDimensionamentoCenter.Click += new System.EventHandler(this.MenusDimensionamento_CheckedChanged);
            // 
            // MenuDimensionamentoZoom
            // 
            this.MenuDimensionamentoZoom.CheckOnClick = true;
            this.MenuDimensionamentoZoom.Name = "MenuDimensionamentoZoom";
            this.MenuDimensionamentoZoom.Size = new System.Drawing.Size(144, 22);
            this.MenuDimensionamentoZoom.Text = "Zoom";
            this.MenuDimensionamentoZoom.Click += new System.EventHandler(this.MenusDimensionamento_CheckedChanged);
            // 
            // linkCaminho
            // 
            this.linkCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCaminho.AutoSize = true;
            this.linkCaminho.Location = new System.Drawing.Point(356, 37);
            this.linkCaminho.Name = "linkCaminho";
            this.linkCaminho.Size = new System.Drawing.Size(16, 13);
            this.linkCaminho.TabIndex = 1;
            this.linkCaminho.TabStop = true;
            this.linkCaminho.Text = "...";
            this.linkCaminho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCaminho_LinkClicked);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(533, 59);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(111, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar imagem...";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // labelModo
            // 
            this.labelModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModo.AutoSize = true;
            this.labelModo.Location = new System.Drawing.Point(376, 97);
            this.labelModo.Name = "labelModo";
            this.labelModo.Size = new System.Drawing.Size(37, 13);
            this.labelModo.TabIndex = 3;
            this.labelModo.Text = "Modo:";
            // 
            // comboModo
            // 
            this.comboModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModo.FormattingEnabled = true;
            this.comboModo.Items.AddRange(new object[] {
            "Normal",
            "Escala de cinza",
            "Vermelho",
            "Verde",
            "Azul",
            "Amarelo (vermelho + verde)",
            "Rosa (vermelho + azul)",
            "Verde-água (verde + azul)",
            "Personalizado"});
            this.comboModo.Location = new System.Drawing.Point(419, 94);
            this.comboModo.Name = "comboModo";
            this.comboModo.Size = new System.Drawing.Size(279, 21);
            this.comboModo.TabIndex = 4;
            this.comboModo.SelectedIndexChanged += new System.EventHandler(this.comboModo_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(704, 93);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // linkResetar
            // 
            this.linkResetar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkResetar.AutoSize = true;
            this.linkResetar.Location = new System.Drawing.Point(549, 118);
            this.linkResetar.Name = "linkResetar";
            this.linkResetar.Size = new System.Drawing.Size(44, 13);
            this.linkResetar.TabIndex = 6;
            this.linkResetar.TabStop = true;
            this.linkResetar.Text = "Resetar";
            this.linkResetar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkResetar_LinkClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(786, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAplicar,
            this.toolStripSeparator1,
            this.MenuSalvarComo});
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MenuArquivo.Text = "Arquivo";
            // 
            // MenuAplicar
            // 
            this.MenuAplicar.Enabled = false;
            this.MenuAplicar.Name = "MenuAplicar";
            this.MenuAplicar.Size = new System.Drawing.Size(235, 22);
            this.MenuAplicar.Text = "Aplicar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // MenuSalvarComo
            // 
            this.MenuSalvarComo.Enabled = false;
            this.MenuSalvarComo.Name = "MenuSalvarComo";
            this.MenuSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSalvarComo.Size = new System.Drawing.Size(235, 22);
            this.MenuSalvarComo.Text = "Salvar imagem como...";
            this.MenuSalvarComo.Click += new System.EventHandler(this.MenuSalvarComo_Click);
            // 
            // panelProgressoFundo
            // 
            this.panelProgressoFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProgressoFundo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelProgressoFundo.Controls.Add(this.panelProgressoFrente);
            this.panelProgressoFundo.Location = new System.Drawing.Point(359, 148);
            this.panelProgressoFundo.Name = "panelProgressoFundo";
            this.panelProgressoFundo.Size = new System.Drawing.Size(415, 5);
            this.panelProgressoFundo.TabIndex = 8;
            this.panelProgressoFundo.Visible = false;
            // 
            // panelProgressoFrente
            // 
            this.panelProgressoFrente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProgressoFrente.BackColor = System.Drawing.Color.OrangeRed;
            this.panelProgressoFrente.Location = new System.Drawing.Point(0, 0);
            this.panelProgressoFrente.Name = "panelProgressoFrente";
            this.panelProgressoFrente.Size = new System.Drawing.Size(0, 5);
            this.panelProgressoFrente.TabIndex = 9;
            this.panelProgressoFrente.Visible = false;
            // 
            // checkAlterarAutomaticamente
            // 
            this.checkAlterarAutomaticamente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlterarAutomaticamente.AutoSize = true;
            this.checkAlterarAutomaticamente.Location = new System.Drawing.Point(359, 172);
            this.checkAlterarAutomaticamente.Name = "checkAlterarAutomaticamente";
            this.checkAlterarAutomaticamente.Size = new System.Drawing.Size(140, 17);
            this.checkAlterarAutomaticamente.TabIndex = 9;
            this.checkAlterarAutomaticamente.Text = "Alterar automaticamente";
            this.checkAlterarAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // checkModificarOriginal
            // 
            this.checkModificarOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkModificarOriginal.AutoSize = true;
            this.checkModificarOriginal.Location = new System.Drawing.Point(505, 172);
            this.checkModificarOriginal.Name = "checkModificarOriginal";
            this.checkModificarOriginal.Size = new System.Drawing.Size(152, 17);
            this.checkModificarOriginal.TabIndex = 10;
            this.checkModificarOriginal.Text = "Modificar o arquivo original";
            this.checkModificarOriginal.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupPersonalizar
            // 
            this.groupPersonalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPersonalizar.Controls.Add(this.trackB);
            this.groupPersonalizar.Controls.Add(this.trackA);
            this.groupPersonalizar.Controls.Add(this.label1);
            this.groupPersonalizar.Controls.Add(this.labelA);
            this.groupPersonalizar.Controls.Add(this.labelB);
            this.groupPersonalizar.Controls.Add(this.trackR);
            this.groupPersonalizar.Controls.Add(this.label4);
            this.groupPersonalizar.Controls.Add(this.label2);
            this.groupPersonalizar.Controls.Add(this.labelR);
            this.groupPersonalizar.Controls.Add(this.labelG);
            this.groupPersonalizar.Controls.Add(this.trackG);
            this.groupPersonalizar.Controls.Add(this.label3);
            this.groupPersonalizar.Location = new System.Drawing.Point(359, 196);
            this.groupPersonalizar.Name = "groupPersonalizar";
            this.groupPersonalizar.Size = new System.Drawing.Size(415, 242);
            this.groupPersonalizar.TabIndex = 11;
            this.groupPersonalizar.TabStop = false;
            this.groupPersonalizar.Text = "Personalizar";
            this.groupPersonalizar.Visible = false;
            // 
            // trackB
            // 
            this.trackB.Location = new System.Drawing.Point(36, 184);
            this.trackB.Maximum = 100;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(104, 45);
            this.trackB.TabIndex = 34;
            this.trackB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackB.Value = 100;
            this.trackB.ValueChanged += new System.EventHandler(this.trackB_ValueChanged);
            // 
            // trackA
            // 
            this.trackA.Location = new System.Drawing.Point(36, 28);
            this.trackA.Maximum = 100;
            this.trackA.Name = "trackA";
            this.trackA.Size = new System.Drawing.Size(104, 45);
            this.trackA.TabIndex = 25;
            this.trackA.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackA.Value = 100;
            this.trackA.ValueChanged += new System.EventHandler(this.trackA_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "A:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(146, 32);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(33, 13);
            this.labelA.TabIndex = 27;
            this.labelA.Text = "100%";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(146, 188);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(33, 13);
            this.labelB.TabIndex = 36;
            this.labelB.Text = "100%";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // trackR
            // 
            this.trackR.Location = new System.Drawing.Point(35, 79);
            this.trackR.Maximum = 100;
            this.trackR.Name = "trackR";
            this.trackR.Size = new System.Drawing.Size(104, 45);
            this.trackR.TabIndex = 28;
            this.trackR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackR.Value = 100;
            this.trackR.ValueChanged += new System.EventHandler(this.trackR_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "R:";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(145, 83);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(33, 13);
            this.labelR.TabIndex = 30;
            this.labelR.Text = "100%";
            this.labelR.Click += new System.EventHandler(this.labelR_Click);
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(145, 134);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(33, 13);
            this.labelG.TabIndex = 33;
            this.labelG.Text = "100%";
            this.labelG.Click += new System.EventHandler(this.labelG_Click);
            // 
            // trackG
            // 
            this.trackG.Location = new System.Drawing.Point(35, 130);
            this.trackG.Maximum = 100;
            this.trackG.Name = "trackG";
            this.trackG.Size = new System.Drawing.Size(104, 45);
            this.trackG.TabIndex = 31;
            this.trackG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackG.Value = 100;
            this.trackG.ValueChanged += new System.EventHandler(this.trackG_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "G:";
            // 
            // groupOpçõesEscalaCinza
            // 
            this.groupOpçõesEscalaCinza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOpçõesEscalaCinza.Controls.Add(this.checkLinhasVerticais);
            this.groupOpçõesEscalaCinza.Controls.Add(this.groupLinhas);
            this.groupOpçõesEscalaCinza.Controls.Add(this.labelLuminosidade);
            this.groupOpçõesEscalaCinza.Controls.Add(this.label5);
            this.groupOpçõesEscalaCinza.Controls.Add(this.TrackLuminosidade);
            this.groupOpçõesEscalaCinza.Location = new System.Drawing.Point(359, 196);
            this.groupOpçõesEscalaCinza.Name = "groupOpçõesEscalaCinza";
            this.groupOpçõesEscalaCinza.Size = new System.Drawing.Size(415, 242);
            this.groupOpçõesEscalaCinza.TabIndex = 37;
            this.groupOpçõesEscalaCinza.TabStop = false;
            this.groupOpçõesEscalaCinza.Text = "Opções da escala de cinza";
            this.groupOpçõesEscalaCinza.Visible = false;
            // 
            // labelLuminosidade
            // 
            this.labelLuminosidade.AutoSize = true;
            this.labelLuminosidade.Location = new System.Drawing.Point(235, 56);
            this.labelLuminosidade.Name = "labelLuminosidade";
            this.labelLuminosidade.Size = new System.Drawing.Size(33, 13);
            this.labelLuminosidade.TabIndex = 2;
            this.labelLuminosidade.Text = "100%";
            this.labelLuminosidade.Click += new System.EventHandler(this.labelLuminosidade_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Luminosidade:";
            // 
            // TrackLuminosidade
            // 
            this.TrackLuminosidade.Location = new System.Drawing.Point(87, 28);
            this.TrackLuminosidade.Maximum = 200;
            this.TrackLuminosidade.Name = "TrackLuminosidade";
            this.TrackLuminosidade.Size = new System.Drawing.Size(322, 45);
            this.TrackLuminosidade.TabIndex = 0;
            this.TrackLuminosidade.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackLuminosidade.Value = 100;
            this.TrackLuminosidade.ValueChanged += new System.EventHandler(this.TrackLuminosidade_ValueChanged);
            // 
            // checkLinhasVerticais
            // 
            this.checkLinhasVerticais.AutoSize = true;
            this.checkLinhasVerticais.Location = new System.Drawing.Point(12, 63);
            this.checkLinhasVerticais.Name = "checkLinhasVerticais";
            this.checkLinhasVerticais.Size = new System.Drawing.Size(119, 17);
            this.checkLinhasVerticais.TabIndex = 3;
            this.checkLinhasVerticais.Text = "Criar linhas verticais";
            this.checkLinhasVerticais.UseVisualStyleBackColor = true;
            this.checkLinhasVerticais.CheckedChanged += new System.EventHandler(this.checkRetro_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor máximo:";
            // 
            // labelValidacao
            // 
            this.labelValidacao.AutoSize = true;
            this.labelValidacao.Location = new System.Drawing.Point(243, 81);
            this.labelValidacao.Name = "labelValidacao";
            this.labelValidacao.Size = new System.Drawing.Size(25, 13);
            this.labelValidacao.TabIndex = 9;
            this.labelValidacao.Text = "100";
            // 
            // trackValidacao
            // 
            this.trackValidacao.Location = new System.Drawing.Point(98, 61);
            this.trackValidacao.Maximum = 10000;
            this.trackValidacao.Name = "trackValidacao";
            this.trackValidacao.Size = new System.Drawing.Size(296, 45);
            this.trackValidacao.TabIndex = 8;
            this.trackValidacao.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackValidacao.Value = 100;
            this.trackValidacao.ValueChanged += new System.EventHandler(this.trackValidacao_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Validação:";
            // 
            // groupLinhas
            // 
            this.groupLinhas.Controls.Add(this.labelValorMaximo);
            this.groupLinhas.Controls.Add(this.labelValidacao);
            this.groupLinhas.Controls.Add(this.label6);
            this.groupLinhas.Controls.Add(this.trackValidacao);
            this.groupLinhas.Controls.Add(this.trackValorMaximo);
            this.groupLinhas.Controls.Add(this.label8);
            this.groupLinhas.Enabled = false;
            this.groupLinhas.Location = new System.Drawing.Point(6, 86);
            this.groupLinhas.Name = "groupLinhas";
            this.groupLinhas.Size = new System.Drawing.Size(403, 111);
            this.groupLinhas.TabIndex = 10;
            this.groupLinhas.TabStop = false;
            this.groupLinhas.Text = "Opções de linhas verticais";
            // 
            // trackValorMaximo
            // 
            this.trackValorMaximo.Location = new System.Drawing.Point(98, 19);
            this.trackValorMaximo.Maximum = 10000;
            this.trackValorMaximo.Name = "trackValorMaximo";
            this.trackValorMaximo.Size = new System.Drawing.Size(296, 45);
            this.trackValorMaximo.TabIndex = 5;
            this.trackValorMaximo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackValorMaximo.Value = 256;
            this.trackValorMaximo.ValueChanged += new System.EventHandler(this.trackValorMaximo_ValueChanged);
            // 
            // labelValorMaximo
            // 
            this.labelValorMaximo.AutoSize = true;
            this.labelValorMaximo.Location = new System.Drawing.Point(243, 42);
            this.labelValorMaximo.Name = "labelValorMaximo";
            this.labelValorMaximo.Size = new System.Drawing.Size(25, 13);
            this.labelValorMaximo.TabIndex = 10;
            this.labelValorMaximo.Text = "256";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.groupOpçõesEscalaCinza);
            this.Controls.Add(this.groupPersonalizar);
            this.Controls.Add(this.checkModificarOriginal);
            this.Controls.Add(this.checkAlterarAutomaticamente);
            this.Controls.Add(this.panelProgressoFundo);
            this.Controls.Add(this.linkResetar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.comboModo);
            this.Controls.Add(this.labelModo);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.linkCaminho);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ctmPictureBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelProgressoFundo.ResumeLayout(false);
            this.groupPersonalizar.ResumeLayout(false);
            this.groupPersonalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            this.groupOpçõesEscalaCinza.ResumeLayout(false);
            this.groupOpçõesEscalaCinza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackLuminosidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValidacao)).EndInit();
            this.groupLinhas.ResumeLayout(false);
            this.groupLinhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValorMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.LinkLabel linkCaminho;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label labelModo;
        private System.Windows.Forms.ComboBox comboModo;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.LinkLabel linkResetar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MenuSalvarComo;
        private System.Windows.Forms.Panel panelProgressoFundo;
        private System.Windows.Forms.Panel panelProgressoFrente;
        private System.Windows.Forms.CheckBox checkAlterarAutomaticamente;
        private System.Windows.Forms.CheckBox checkModificarOriginal;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupPersonalizar;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.TrackBar trackA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TrackBar trackR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TrackBar trackG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupOpçõesEscalaCinza;
        private System.Windows.Forms.Label labelLuminosidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackLuminosidade;
        private System.Windows.Forms.ContextMenuStrip ctmPictureBox;
        private System.Windows.Forms.ToolStripMenuItem MenuModoDimensionamento;
        private System.Windows.Forms.ToolStripMenuItem MenuDimensionamentoNormal;
        private System.Windows.Forms.ToolStripMenuItem MenuDimensionamentoStretch;
        private System.Windows.Forms.ToolStripMenuItem MenuDimensionamentoAuto;
        private System.Windows.Forms.ToolStripMenuItem MenuDimensionamentoCenter;
        private System.Windows.Forms.ToolStripMenuItem MenuDimensionamentoZoom;
        private System.Windows.Forms.ToolStripMenuItem MenuAplicar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkLinhasVerticais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelValidacao;
        private System.Windows.Forms.TrackBar trackValidacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupLinhas;
        private System.Windows.Forms.Label labelValorMaximo;
        private System.Windows.Forms.TrackBar trackValorMaximo;
    }
}

