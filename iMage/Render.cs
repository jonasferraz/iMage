using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace iMage
{
    public class Render
    {
        public Render (Bitmap img)
        {
            Imagem = img;
        }

        public Render (string nomeArquivo)
        {
            Imagem = (Bitmap)Image.FromFile(nomeArquivo);
        }

        public Bitmap Imagem;

        private int a, r, g, b;

        private Color cor;

        // Verifica se a imagem possui canal alfa diferente de 255.
        public bool PossuiAlfa(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color cor = img.GetPixel(x, y);
                    if (cor.A != 255)
                        return true;
                }
            }
            
            return false;
        }

        public void Salvar(string nomeArq)
        {
            string extensaoArquivo = nomeArq.Split('.')[nomeArq.Split('.').Count()-1].ToLower();
            if ((extensaoArquivo != "png") && (PossuiAlfa(Imagem)))
            {
                DialogResult salvarTransparente = MessageBox.Show("Todas as transparências serão perdidas se você salvar nesse formato. Se quiser manter as transparências, salve no formato png. Deseja salvar mesmo assim?", "Canal alfa detectado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (salvarTransparente == DialogResult.No)
                    return;
            }
            if ((extensaoArquivo == "jpg") || (extensaoArquivo == "jpeg"))
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Jpeg);
            else if (extensaoArquivo == "gif")
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Gif);
            else if (extensaoArquivo == "bmp")
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Bmp);
            else if (extensaoArquivo == "ico")
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Icon);
            else if (extensaoArquivo == "tiff")
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Tiff);
            else if (extensaoArquivo == "png")
                Imagem.Save(nomeArq, System.Drawing.Imaging.ImageFormat.Png);
        }

        public Bitmap AplicarEscalaDeCinza(Bitmap img, int lux)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        r = cor.R;
                        g = cor.G;
                        b = cor.B;
                        int c = (int)((((decimal)(r) + (decimal)g + (decimal)b) / (decimal)3)*(decimal)lux/(decimal)100);
                        if (c > 255)
                            c = 255;
                        img.SetPixel(x, y, Color.FromArgb(a, c, c, c));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o efeito escala de cinza: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarVermelho (Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        r = cor.R;
                        img.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro vermelho: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarVerde(Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        g = cor.G;
                        img.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro verde: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarAzul(Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        b = cor.B;
                        img.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro azul: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarAmarelo(Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        r = cor.R;
                        g = cor.G;
                        img.SetPixel(x, y, Color.FromArgb(a, r, g, 0));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro amarelo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarRosa(Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        r = cor.R;
                        b = cor.B;
                        img.SetPixel(x, y, Color.FromArgb(a, r, 0, b));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro rosa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarVerdeAzul(Bitmap img)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        g = cor.G;
                        b = cor.B;
                        img.SetPixel(x, y, Color.FromArgb(a, 0, g, b));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro verde-água: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public Bitmap AplicarPersonalizado(Bitmap img, int va, int vr, int vg, int vb)
        {
            try
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        cor = img.GetPixel(x, y);
                        a = cor.A;
                        r = cor.R;
                        g = cor.G;
                        b = cor.B;
                        a = (int)((decimal)a * (decimal)va / (decimal)100);
                        r = (int)((decimal)r * (decimal)vr / (decimal)100);
                        g = (int)((decimal)g * (decimal)vg / (decimal)100);
                        b = (int)((decimal)b * (decimal)vb / (decimal)100);
                        img.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o filtro personalizado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
