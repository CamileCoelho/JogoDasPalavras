using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace JogoDasPalavras.WinFormsApp
{
    public partial class Form1 : Form
    {
        private JogoDasPalavras jogo;

        private List<Button> listaBotoes = new List<Button>();

        private List<TextBox> letrasTextBoxes;

        public string palavraImputada1, palavraImputada2, palavraImputada3,
            palavraImputada4, palavraImputada5, palavraImputada6;

        public Form1()
        {
            InitializeComponent();

            jogo = new JogoDasPalavras();

            RegistrarEventos();

        }

        private List<string> letrasClicadas = new();

        private void btnLetra_Click(object sender, EventArgs e)
        {
            Button botaoLetra = (Button)sender;
            string letra = botaoLetra.Text;

            foreach (TextBox textBox in letrasTextBoxes)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = letra;
                    break;
                }
            }
        }

        private void RegistrarEventos()
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                botao.Click += SalvarTextoBotao;
            }
        }

        private void SalvarTextoBotao(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;

            letrasClicadas.Add(textoBotao);
        }

        //private void AtribuirLetrasLinha2()
        //{
        //    btnA.Click += AtribuirLetraLinha2;
        //    btnB.Click += AtribuirLetraLinha2;
        //    btnC.Click += AtribuirLetraLinha2;
        //    btnD.Click += AtribuirLetraLinha2;
        //    btnE.Click += AtribuirLetraLinha2;
        //    btnF.Click += AtribuirLetraLinha2;
        //    btnG.Click += AtribuirLetraLinha2;
        //    btnH.Click += AtribuirLetraLinha2;
        //    btnI.Click += AtribuirLetraLinha2;
        //    btnJ.Click += AtribuirLetraLinha2;
        //    btnK.Click += AtribuirLetraLinha2;
        //    btnL.Click += AtribuirLetraLinha2;
        //    btnM.Click += AtribuirLetraLinha2;
        //    btnN.Click += AtribuirLetraLinha2;
        //    btnO.Click += AtribuirLetraLinha2;
        //    btnP.Click += AtribuirLetraLinha2;
        //    btnQ.Click += AtribuirLetraLinha2;
        //    btnR.Click += AtribuirLetraLinha2;
        //    btnS.Click += AtribuirLetraLinha2;
        //    btnT.Click += AtribuirLetraLinha2;
        //    btnU.Click += AtribuirLetraLinha2;
        //    btnV.Click += AtribuirLetraLinha2;
        //    btnW.Click += AtribuirLetraLinha2;
        //    btnX.Click += AtribuirLetraLinha2;
        //    btnY.Click += AtribuirLetraLinha2;
        //    btnZ.Click += AtribuirLetraLinha2;
        //    btnÇ.Click += AtribuirLetraLinha2;
        //}

        //private void AtribuirLetrasLinha3()
        //{
        //    btnA.Click += AtribuirLetraLinha3;
        //    btnB.Click += AtribuirLetraLinha3;
        //    btnC.Click += AtribuirLetraLinha3;
        //    btnD.Click += AtribuirLetraLinha3;
        //    btnE.Click += AtribuirLetraLinha3;
        //    btnF.Click += AtribuirLetraLinha3;
        //    btnG.Click += AtribuirLetraLinha3;
        //    btnH.Click += AtribuirLetraLinha3;
        //    btnI.Click += AtribuirLetraLinha3;
        //    btnJ.Click += AtribuirLetraLinha3;
        //    btnK.Click += AtribuirLetraLinha3;
        //    btnL.Click += AtribuirLetraLinha3;
        //    btnM.Click += AtribuirLetraLinha3;
        //    btnN.Click += AtribuirLetraLinha3;
        //    btnO.Click += AtribuirLetraLinha3;
        //    btnP.Click += AtribuirLetraLinha3;
        //    btnQ.Click += AtribuirLetraLinha3;
        //    btnR.Click += AtribuirLetraLinha3;
        //    btnS.Click += AtribuirLetraLinha3;
        //    btnT.Click += AtribuirLetraLinha3;
        //    btnU.Click += AtribuirLetraLinha3;
        //    btnV.Click += AtribuirLetraLinha3;
        //    btnW.Click += AtribuirLetraLinha3;
        //    btnX.Click += AtribuirLetraLinha3;
        //    btnY.Click += AtribuirLetraLinha3;
        //    btnZ.Click += AtribuirLetraLinha3;
        //    btnÇ.Click += AtribuirLetraLinha3;
        //}

        //private void AtribuirLetrasLinha4()
        //{
        //    btnÇ.Click += AtribuirLetraLinha4;
        //    btnA.Click += AtribuirLetraLinha4;
        //    btnB.Click += AtribuirLetraLinha4;
        //    btnC.Click += AtribuirLetraLinha4;
        //    btnD.Click += AtribuirLetraLinha4;
        //    btnE.Click += AtribuirLetraLinha4;
        //    btnF.Click += AtribuirLetraLinha4;
        //    btnG.Click += AtribuirLetraLinha4;
        //    btnH.Click += AtribuirLetraLinha4;
        //    btnI.Click += AtribuirLetraLinha4;
        //    btnJ.Click += AtribuirLetraLinha4;
        //    btnK.Click += AtribuirLetraLinha4;
        //    btnL.Click += AtribuirLetraLinha4;
        //    btnM.Click += AtribuirLetraLinha4;
        //    btnN.Click += AtribuirLetraLinha4;
        //    btnO.Click += AtribuirLetraLinha4;
        //    btnP.Click += AtribuirLetraLinha4;
        //    btnQ.Click += AtribuirLetraLinha4;
        //    btnR.Click += AtribuirLetraLinha4;
        //    btnS.Click += AtribuirLetraLinha4;
        //    btnT.Click += AtribuirLetraLinha4;
        //    btnU.Click += AtribuirLetraLinha4;
        //    btnV.Click += AtribuirLetraLinha4;
        //    btnW.Click += AtribuirLetraLinha4;
        //    btnX.Click += AtribuirLetraLinha4;
        //    btnY.Click += AtribuirLetraLinha4;
        //    btnZ.Click += AtribuirLetraLinha4;
        //}

        private void AtribuirLetraLinha1(Button botaoClicado)
        {
            if (string.IsNullOrEmpty(txt1A.Text))
            {
                txt1A.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt1B.Text))
            {
                txt1B.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt1C.Text))
            {
                txt1C.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt1D.Text))
            {
                txt1D.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt1E.Text))
            {
                txt1E.Text = botaoClicado.Text;
                return;
            }
        }

        private void AtribuirLetraLinha2(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            if (string.IsNullOrEmpty(txt2A.Text))
            {
                txt2A.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt2B.Text))
            {
                txt2B.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt2C.Text))
            {
                txt2C.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt2D.Text))
            {
                txt2D.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt2E.Text))
            {
                txt2E.Text = botaoClicado.Text;
                return;
            }
        }

        private void AtribuirLetraLinha3(Button botaoClicado)
        {
            if (string.IsNullOrEmpty(txt3A.Text))
            {
                txt3A.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt3B.Text))
            {
                txt3B.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt3C.Text))
            {
                txt3C.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt3D.Text))
            {
                txt3D.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt3E.Text))
            {
                txt3E.Text = botaoClicado.Text;
                return;
            }
        }

        private void AtribuirLetraLinha4(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            if (string.IsNullOrEmpty(txt4A.Text))
            {
                txt4A.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt4B.Text))
            {
                txt4B.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt4C.Text))
            {
                txt4C.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt4D.Text))
            {
                txt4D.Text = botaoClicado.Text;
                return;
            }
            if (string.IsNullOrEmpty(txt4E.Text))
            {
                txt4E.Text = botaoClicado.Text;
                return;
            }
        }

        private void ListarBotoes()
        {
            foreach (Control control in pnlBotoes.Controls)
            {
                if (control is Button button)
                {
                    listaBotoes.Add(button);
                }
            }
        }

        private int contadorPalavra = 1;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1E.Text) && contadorPalavra == 1)
            {
                AtribuirLetraLinha1(botaoClicado);
                palavraImputada1 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
                VerificarPalavra1();
                contadorPalavra++;
            }
            else if (!string.IsNullOrEmpty(txt2E.Text) && palavraImputada1 != jogo.palavraSecreta && contadorPalavra == 2)
            {
                palavraImputada2 = txt2A.Text + txt2B.Text + txt2C.Text + txt2D.Text + txt2E.Text;
                VerificarPalavra2();
                contadorPalavra++;
            }
            else if (!string.IsNullOrEmpty(txt3E.Text) && palavraImputada2 != jogo.palavraSecreta && contadorPalavra == 3)
            {
                palavraImputada3 = txt3A.Text + txt3B.Text + txt3C.Text + txt3D.Text + txt3E.Text;
                VerificarPalavra3();
                contadorPalavra++;
            }
            else if (!string.IsNullOrEmpty(txt4E.Text) && palavraImputada3 != jogo.palavraSecreta && contadorPalavra == 4)
            {
                palavraImputada4 = txt4A.Text + txt4B.Text + txt4C.Text + txt4D.Text + txt4E.Text;
                VerificarPalavra4();
                FinalizarJogo();
                contadorPalavra++;
                return;
            }
        }

        private void FinalizarJogo()
        {
            if (palavraImputada4 != jogo.palavraSecreta)
                MessageBox.Show("Você perdeu...");
            else
                MessageBox.Show("Parabéns, você ganhou!");

            pnlBotoes.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeletarPrimeiraLinha();
            DeletarSegundaLinha();
            DeletarTerceiraLinha();
            DeletarQuartaLinha();
        }

        private void PintarBotaoClicado(TextBox txt, Color cor)
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                if (botao.Text == txt.Text)
                {
                    botao.BackColor = cor;
                }
            }
        }

        private void VerificarPalavra1()
        {
            if (jogo.palavraSecreta == palavraImputada1)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            if (jogo.palavraSecreta != palavraImputada1)
            {
                foreach (Char c in jogo.palavraSecreta)
                {
                    if (palavraImputada1.Contains(c))
                    {
                        PintarBotaoETxtBoxClicado(c, Color.Yellow);
                    }
                }
                if (jogo.palavraSecreta[0] == palavraImputada1[0])
                {
                    txt1A.BackColor = Color.Green;
                    PintarBotaoClicado(txt1A, Color.Green);
                }
                if (jogo.palavraSecreta[1] == palavraImputada1[1])
                {
                    txt1B.BackColor = Color.Green;
                    PintarBotaoClicado(txt1B, Color.Green);
                }
                if (jogo.palavraSecreta[2] == palavraImputada1[2])
                {
                    txt1C.BackColor = Color.Green;
                    PintarBotaoClicado(txt1C, Color.Green);
                }
                if (jogo.palavraSecreta[3] == palavraImputada1[3])
                {
                    txt1D.BackColor = Color.Green;
                    PintarBotaoClicado(txt1D, Color.Green);
                }
                if (jogo.palavraSecreta[4] == palavraImputada1[4])
                {
                    txt1E.BackColor = Color.Green;
                    PintarBotaoClicado(txt1E, Color.Green);
                }
            }
        }

        private void VerificarPalavra2()
        {
            if (jogo.palavraSecreta == palavraImputada2)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            if (jogo.palavraSecreta != palavraImputada2)
            {
                foreach (Char c in jogo.palavraSecreta)
                {
                    if (palavraImputada2.Contains(c))
                    {
                        PintarBotaoETxtBoxClicado(c, Color.Yellow);
                    }
                    else
                    {
                        foreach (TextBox txt in tblLinha2.Controls)
                        {
                            if (txt.Text != c.ToString())
                            {
                                txt.BackColor = Color.Gray;
                            }
                        }
                    }
                }
                if (jogo.palavraSecreta[0] == palavraImputada2[0])
                {
                    txt2A.BackColor = Color.Green;
                    PintarBotaoClicado(txt2A, Color.Green);
                }
                if (jogo.palavraSecreta[1] == palavraImputada2[1])
                {
                    txt2B.BackColor = Color.Green;
                    PintarBotaoClicado(txt2B, Color.Green);
                }
                if (jogo.palavraSecreta[2] == palavraImputada2[2])
                {
                    txt2C.BackColor = Color.Green;
                    PintarBotaoClicado(txt2C, Color.Green);
                }
                if (jogo.palavraSecreta[3] == palavraImputada2[3])
                {
                    txt2D.BackColor = Color.Green;
                    PintarBotaoClicado(txt2D, Color.Green);
                }
                if (jogo.palavraSecreta[4] == palavraImputada2[4])
                {
                    txt2E.BackColor = Color.Green;
                    PintarBotaoClicado(txt2E, Color.Green);
                }
            }
        }

        private void VerificarPalavra3()
        {
            if (jogo.palavraSecreta == palavraImputada3)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            if (jogo.palavraSecreta != palavraImputada3)
            {
                foreach (Char c in jogo.palavraSecreta)
                {
                    if (palavraImputada3.Contains(c))
                    {
                        PintarBotaoETxtBoxClicado(c, Color.Yellow);
                    }
                    else
                    {
                        foreach (TextBox txt in tblLinha3.Controls)
                        {
                            if (txt.Text != c.ToString())
                            {
                                txt.BackColor = Color.Gray;
                            }
                        }
                    }
                }
                if (jogo.palavraSecreta[0] == palavraImputada3[0])
                {
                    txt3A.BackColor = Color.Green;
                    PintarBotaoClicado(txt3A, Color.Green);
                }
                if (jogo.palavraSecreta[1] == palavraImputada3[1])
                {
                    txt3B.BackColor = Color.Green;
                    PintarBotaoClicado(txt3B, Color.Green);
                }
                if (jogo.palavraSecreta[2] == palavraImputada3[2])
                {
                    txt3C.BackColor = Color.Green;
                    PintarBotaoClicado(txt3C, Color.Green);
                }
                if (jogo.palavraSecreta[3] == palavraImputada3[3])
                {
                    txt3D.BackColor = Color.Green;
                    PintarBotaoClicado(txt3D, Color.Green);
                }
                if (jogo.palavraSecreta[4] == palavraImputada3[4])
                {
                    txt3E.BackColor = Color.Green;
                    PintarBotaoClicado(txt3E, Color.Green);
                }
            }
        }

        private void VerificarPalavra4()
        {
            if (jogo.palavraSecreta == palavraImputada4)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            if (jogo.palavraSecreta != palavraImputada4)
            {
                foreach (Char c in jogo.palavraSecreta)
                {
                    if (palavraImputada4.Contains(c))
                    {
                        PintarBotaoETxtBoxClicado(c, Color.Yellow);
                    }
                    else
                    {
                        foreach (TextBox txt in tblLinha4.Controls)
                        {
                            if (txt.Text != c.ToString())
                            {
                                txt.BackColor = Color.Gray;
                            }
                        }
                    }
                }
                if (jogo.palavraSecreta[0] == palavraImputada4[0])
                {
                    txt4A.BackColor = Color.Green;
                    PintarBotaoClicado(txt4A, Color.Green);
                }
                if (jogo.palavraSecreta[1] == palavraImputada4[1])
                {
                    txt4B.BackColor = Color.Green;
                    PintarBotaoClicado(txt4B, Color.Green);
                }
                if (jogo.palavraSecreta[2] == palavraImputada4[2])
                {
                    txt4C.BackColor = Color.Green;
                    PintarBotaoClicado(txt4C, Color.Green);
                }
                if (jogo.palavraSecreta[3] == palavraImputada4[3])
                {
                    txt4D.BackColor = Color.Green;
                    PintarBotaoClicado(txt4D, Color.Green);
                }
                if (jogo.palavraSecreta[4] == palavraImputada4[4])
                {
                    txt4E.BackColor = Color.Green;
                    PintarBotaoClicado(txt4E, Color.Green);
                }
            }
        }

        private void DeletarPrimeiraLinha()
        {
            if (!string.IsNullOrEmpty(txt1E.Text))
            {
                txt1E.Text = txt1E.Text.Substring(0, txt1E.Text.Length - 1);
                txt1E.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1D.Text))
            {
                txt1D.Text = txt1D.Text.Substring(0, txt1D.Text.Length - 1);
                txt1D.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1C.Text))
            {
                txt1C.Text = txt1C.Text.Substring(0, txt1C.Text.Length - 1);
                txt1C.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1B.Text))
            {
                txt1B.Text = txt1B.Text.Substring(0, txt1B.Text.Length - 1);
                txt1B.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1A.Text))
            {
                txt1A.Text = txt1A.Text.Substring(0, txt1A.Text.Length - 1);
                txt1A.BackColor = Color.Empty;
                return;
            }
        }

        private void DeletarSegundaLinha()
        {
            if (!string.IsNullOrEmpty(txt2E.Text))
            {
                txt2E.Text = txt2E.Text.Substring(0, txt2E.Text.Length - 1);
                txt2E.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt2D.Text))
            {
                txt2D.Text = txt2D.Text.Substring(0, txt2D.Text.Length - 1);
                txt2D.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt2C.Text))
            {
                txt2C.Text = txt2C.Text.Substring(0, txt2C.Text.Length - 1);
                txt2C.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt2B.Text))
            {
                txt2B.Text = txt2B.Text.Substring(0, txt2B.Text.Length - 1);
                txt2B.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt2A.Text))
            {
                txt2A.Text = txt2A.Text.Substring(0, txt2A.Text.Length - 1);
                txt2A.BackColor = Color.Empty;
                return;
            }
        }

        private void DeletarTerceiraLinha()
        {
            if (!string.IsNullOrEmpty(txt3E.Text))
            {
                txt3E.Text = txt3E.Text.Substring(0, txt3E.Text.Length - 1);
                txt3E.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt3D.Text))
            {
                txt3D.Text = txt3D.Text.Substring(0, txt3D.Text.Length - 1);
                txt3D.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt3C.Text))
            {
                txt3C.Text = txt3C.Text.Substring(0, txt3C.Text.Length - 1);
                txt3C.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt3B.Text))
            {
                txt3B.Text = txt3B.Text.Substring(0, txt3B.Text.Length - 1);
                txt3B.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt3A.Text))
            {
                txt3A.Text = txt3A.Text.Substring(0, txt3A.Text.Length - 1);
                txt3A.BackColor = Color.Empty;
                return;
            }
        }

        private void DeletarQuartaLinha()
        {
            if (!string.IsNullOrEmpty(txt4E.Text))
            {
                txt4E.Text = txt4E.Text.Substring(0, txt4E.Text.Length - 1);
                txt4E.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt4D.Text))
            {
                txt4D.Text = txt4D.Text.Substring(0, txt4D.Text.Length - 1);
                txt4D.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt4C.Text))
            {
                txt4C.Text = txt4C.Text.Substring(0, txt4C.Text.Length - 1);
                txt4C.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt4B.Text))
            {
                txt4B.Text = txt4B.Text.Substring(0, txt4B.Text.Length - 1);
                txt4B.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt4A.Text))
            {
                txt4A.Text = txt4A.Text.Substring(0, txt4A.Text.Length - 1);
                txt4A.BackColor = Color.Empty;
                return;
            }
        }

        private void PintarBotaoETxtBoxClicado(Char c, Color cor)
        {
            foreach (TextBox txt in tblLinha1.Controls)
            {
                if (txt.Text == c.ToString())
                {
                    txt.BackColor = cor;
                }
            }
            foreach (Button botao in pnlBotoes.Controls)
            {
                if (botao.Text == c.ToString())
                {
                    botao.BackColor = cor;
                }
            }
        }
    }
}