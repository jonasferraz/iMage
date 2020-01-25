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

        private void linkCaminho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] aux = linkCaminho.Text.Split('\\');
            string caminho = "";
            for (int x = 0; x < aux.Count() - 1; x++)
                caminho += aux[x] + "\\";
            Process.Start(caminho);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog { AddExtension = true, CheckFileExists = true, CheckPathExists = true, Filter = "Portable Network Graphics|*.png|Arquivo JPEG|*.jpg; *.jpeg|Arquivo bitmap|*.bmp|Arquivo GIF|*.gif|Todos os arquivos|*.*", Title = "Selecionar arquivo", Multiselect = false, FilterIndex = 5 })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    linkCaminho.Text = fbd.FileName;
                    render = new Render(fbd.FileName);
                    picImagem.Image = render.Imagem;
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
                    switch (comboModo.SelectedIndex)
                    {
                        case 1:
                            {
                                imagem = render.AplicarEscalaDeCinza(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 2:
                            {
                                imagem = render.AplicarVermelho(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 3:
                            {
                                imagem = render.AplicarVerde(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 4:
                            {
                                imagem = render.AplicarAzul(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 5:
                            {
                                imagem = render.AplicarAmarelo(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 6:
                            {
                                imagem = render.AplicarRosa(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 7:
                            {
                                imagem = render.AplicarVerdeAzul(render.Imagem);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                        case 8:
                            {
                                imagem = render.AplicarPersonalizado(render.Imagem, trackA.Value, trackR.Value, trackG.Value, trackB.Value);
                                if (imagem != null)
                                    picImagem.Image = render.Imagem = imagem;
                                break;
                            }
                    }
                }
                if (picImagem.Image != null)
                    MenuSalvarComo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboModo.SelectedIndex = 0;
        }

        private void comboModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModo.SelectedIndex == 8)
                groupPersonalizar.Visible = true;
            else
                groupPersonalizar.Visible = false;

            if (checkAlterarAutomaticamente.Checked)
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

        private void trackA_ValueChanged(object sender, EventArgs e)
        {
            labelA.Text = trackA.Value + "%";
        }

        private void trackR_ValueChanged(object sender, EventArgs e)
        {
            labelR.Text = trackR.Value + "%";
        }

        private void trackG_ValueChanged(object sender, EventArgs e)
        {
            labelG.Text = trackG.Value + "%";
        }

        private void trackB_ValueChanged(object sender, EventArgs e)
        {
            labelB.Text = trackB.Value + "%";
        }

        private void labelA_Click(object sender, EventArgs e)
        {
            trackA.Value = 100;
        }

        private void labelR_Click(object sender, EventArgs e)
        {
            trackR.Value = 100;
        }

        private void labelG_Click(object sender, EventArgs e)
        {
            trackG.Value = 100;
        }

        private void labelB_Click(object sender, EventArgs e)
        {
            trackB.Value = 100;
        }
    }
}
