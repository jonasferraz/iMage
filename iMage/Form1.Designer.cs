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
            this.linkCaminho = new System.Windows.Forms.LinkLabel();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.labelModo = new System.Windows.Forms.Label();
            this.comboModo = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.linkResetar = new System.Windows.Forms.LinkLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProgressoFundo = new System.Windows.Forms.Panel();
            this.panelProgressoFrente = new System.Windows.Forms.Panel();
            this.checkAlterarAutomaticamente = new System.Windows.Forms.CheckBox();
            this.checkModificarOriginal = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupPersonalizar = new System.Windows.Forms.GroupBox();
            this.labelB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.labelG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.labelR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackR = new System.Windows.Forms.TrackBar();
            this.labelA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackA = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panelProgressoFundo.SuspendLayout();
            this.groupPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).BeginInit();
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
            this.picImagem.Location = new System.Drawing.Point(13, 37);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(337, 401);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
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
            this.MenuSalvarComo});
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MenuArquivo.Text = "Arquivo";
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
            this.groupPersonalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "B:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "G:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "R:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "A:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
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
            this.Text = "iMage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelProgressoFundo.ResumeLayout(false);
            this.groupPersonalizar.ResumeLayout(false);
            this.groupPersonalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).EndInit();
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
    }
}

