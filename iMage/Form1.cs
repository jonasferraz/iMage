﻿using System;
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

namespace iMage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Render render;

        int tempo_mover = 0;

        bool modificado = false;

        private void linkCaminho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkCaminho.Text != "...")
                Process.Start(linkCaminho.Text);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog { AddExtension = true, CheckFileExists = true, CheckPathExists = true, Filter = "Portable Network Graphics|*.png|Arquivo JPEG|*.jpg; *.jpeg|Arquivo bitmap|*.bmp|Arquivo GIF|*.gif|Arquivos de imagem|*.png; *.jpg; *.jpeg; *.bmp; *.gif|Todos os arquivos|*.*", Title = "Selecionar arquivo", Multiselect = false, FilterIndex = 5 })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    linkCaminho.Text = fbd.FileName;
                    render = new Render(fbd.FileName);
                    picImagem.Image = render.Imagem;
                    btnAplicar.Enabled = MenuAplicar.Enabled = true;
                }
            }
        }

        private void linkResetar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (File.Exists(linkCaminho.Text))
                {
                    render = new Render(linkCaminho.Text);
                    picImagem.Image = render.Imagem;
                }
                else
                    MessageBox.Show("O arquivo solicitado não existe. Verifique se ele não foi movido ou excluído e tente novamente.", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a imagem. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuSalvarComo_Click(object sender, EventArgs e)
        {
            if (picImagem.Image != null)
            {
                using (var sfd = new SaveFileDialog { AddExtension = true, OverwritePrompt = true, CheckPathExists = true, Filter = "Portable Network Graphics|*.png|Arquivo JPEG|*.jpg; *.jpeg|Arquivo bitmap|*.bmp|Arquivo GIF|*.gif|Todos os arquivos|*.*", Title = "Selecionar arquivo", SupportMultiDottedExtensions = true, FilterIndex = 2 })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        render.Salvar(sfd.FileName);
                        modificado = false;
                    }
                }
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            try
            {
                if (comboModo.SelectedIndex == 0)
                {
                    render = new Render(linkCaminho.Text);
                    picImagem.Image = render.Imagem;
                }
                else
                {
                    if (checkModificarOriginal.Checked)
                        render.Imagem = (Bitmap)Image.FromFile(linkCaminho.Text);
                    Bitmap imagem;
                    panelProgressoFundo.Visible = true;
                    panelProgressoFrente.Visible = true;
                    switch (comboModo.SelectedIndex)
                    {
                        case 1:
                            {
                                imagem = render.AplicarEscalaDeCinza(render.Imagem, TrackLuminosidade.Value, checkLinhasVerticais.Checked, trackValorMaximo.Value, trackValidacao.Value, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 2:
                            {
                                imagem = render.AplicarVermelho(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 3:
                            {
                                imagem = render.AplicarVerde(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 4:
                            {
                                imagem = render.AplicarAzul(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 5:
                            {
                                imagem = render.AplicarAmarelo(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 6:
                            {
                                imagem = render.AplicarRosa(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 7:
                            {
                                imagem = render.AplicarVerdeAzul(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 8:
                            {
                                imagem = render.InverterCores(render.Imagem, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 9:
                            {
                                imagem = render.AplicarPersonalizado(render.Imagem, trackA.Value, trackR.Value, trackG.Value, trackB.Value, panelProgressoFrente, panelProgressoFundo.Width);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                    }
                }
                if (picImagem.Image != null)
                {
                    MenuSalvarComo.Enabled = true;
                    modificado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
                panelProgressoFrente.Visible = false;
                panelProgressoFundo.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboModo.SelectedIndex = 0;
        }

        private void comboModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModo.SelectedIndex == 9)
                groupPersonalizar.Visible = true;
            else
                groupPersonalizar.Visible = false;

            if (comboModo.SelectedIndex == 1)
                groupOpçõesEscalaCinza.Visible = true;
            else
                groupOpçõesEscalaCinza.Visible = false;

            if ((checkAlterarAutomaticamente.Checked) && (comboModo.SelectedIndex != 9))
                btnAplicar.PerformClick();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Text = $"iMage (posição: ({this.Location.X}; {this.Location.Y}))";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempo_mover += timer.Interval;
            if (tempo_mover >= 5000)
            {
                tempo_mover = 0;
                timer.Stop();
                this.Text = "iMage";
            }
        }

        private void trackA_ValueChanged(object sender, EventArgs e) => labelA.Text = trackA.Value + "%";

        private void trackR_ValueChanged(object sender, EventArgs e) => labelR.Text = trackR.Value + "%";

        private void trackG_ValueChanged(object sender, EventArgs e) => labelG.Text = trackG.Value + "%";

        private void trackB_ValueChanged(object sender, EventArgs e) => labelB.Text = trackB.Value + "%";

        private void labelA_Click(object sender, EventArgs e) => trackA.Value = 100;

        private void labelR_Click(object sender, EventArgs e) => trackR.Value = 100;

        private void labelG_Click(object sender, EventArgs e) => trackG.Value = 100;

        private void labelB_Click(object sender, EventArgs e) => trackB.Value = 100;

        private void TrackLuminosidade_ValueChanged(object sender, EventArgs e)
        {
            labelLuminosidade.Text = $"{TrackLuminosidade.Value}%";
            if (checkAlterarAutomaticamente.Checked)
                btnAplicar.PerformClick();
        }

        private void DesmarcarOpções (ToolStripMenuItem item, ToolStripMenuItem ex)
        {
            foreach (var x in item.DropDownItems.OfType<ToolStripMenuItem>())
            {
                if (x != ex)
                    x.Checked = false;
            }
        }

        private void MenusDimensionamento_CheckedChanged (object sender, EventArgs e)
        {
            DesmarcarOpções(MenuModoDimensionamento, sender as ToolStripMenuItem);
            DimensionaImagem();
        }

        private void DimensionaImagem()
        {
            if (MenuDimensionamentoNormal.Checked)
                picImagem.SizeMode = PictureBoxSizeMode.Normal;
            else if (MenuDimensionamentoStretch.Checked)
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (MenuDimensionamentoAuto.Checked)
                picImagem.SizeMode = PictureBoxSizeMode.AutoSize;
            else if (MenuDimensionamentoCenter.Checked)
                picImagem.SizeMode = PictureBoxSizeMode.CenterImage;
            else if (MenuDimensionamentoZoom.Checked)
                picImagem.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void labelLuminosidade_Click(object sender, EventArgs e) => TrackLuminosidade.Value = 100;

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = $"iMage (tamanho: ({this.Size.Width}; {this.Size.Height}))";
            timer.Start();
        }

        private void checkRetro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAlterarAutomaticamente.Checked)
                btnAplicar.PerformClick();

            if (checkLinhasVerticais.Checked)
                groupLinhas.Enabled = true;
            else
                groupLinhas.Enabled = false;
        }

        private void trackValorMaximo_ValueChanged(object sender, EventArgs e)
        {
            labelValorMaximo.Text = trackValorMaximo.Value.ToString();
        }

        private void trackValidacao_ValueChanged(object sender, EventArgs e)
        {
            labelValidacao.Text = trackValidacao.Value.ToString();
        }

        private void MenuAbrir_Click(object sender, EventArgs e) => btnCarregar.PerformClick();

        private void MenuSair_Click(object sender, EventArgs e)
        {
            if (modificado)
            {
                DialogResult sair = MessageBox.Show("O arquivo ainda não foi salvo. Deseja salvá-lo agora?", "Saindo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (sair == DialogResult.Yes)
                {
                    MenuSalvarComo.PerformClick();
                    Application.ExitThread();
                }
                else if (sair == DialogResult.No)
                    Application.ExitThread();
            }
            else
                Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MenuSair.PerformClick();
        }

        private void MenuAplicar_Click(object sender, EventArgs e)
        {
            btnAplicar.PerformClick();
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            using (Sobre sobre = new Sobre())
                sobre.ShowDialog();
        }
    }
}
