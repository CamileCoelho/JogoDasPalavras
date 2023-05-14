namespace JogoDasPalavras.WinFormsApp
{
    public partial class Form1 : Form
    {
        private JogoDasPalavras jogo;

        public string palavraImputada1;

        public Form1()
        {
            InitializeComponent();

            jogo = new JogoDasPalavras();

            btnA.Click += AtribuirLetraLinha1;
            btnB.Click += AtribuirLetraLinha1;
            btnC.Click += AtribuirLetraLinha1;
            btnD.Click += AtribuirLetraLinha1;
            btnE.Click += AtribuirLetraLinha1;
            btnF.Click += AtribuirLetraLinha1;
            btnG.Click += AtribuirLetraLinha1;
            btnH.Click += AtribuirLetraLinha1;
            btnI.Click += AtribuirLetraLinha1;
            btnJ.Click += AtribuirLetraLinha1;
            btnK.Click += AtribuirLetraLinha1;
            btnL.Click += AtribuirLetraLinha1;
            btnM.Click += AtribuirLetraLinha1;
            btnN.Click += AtribuirLetraLinha1;
            btnO.Click += AtribuirLetraLinha1;
            btnP.Click += AtribuirLetraLinha1;
            btnQ.Click += AtribuirLetraLinha1;
            btnR.Click += AtribuirLetraLinha1;
            btnS.Click += AtribuirLetraLinha1;
            btnT.Click += AtribuirLetraLinha1;
            btnU.Click += AtribuirLetraLinha1;
            btnV.Click += AtribuirLetraLinha1;
            btnW.Click += AtribuirLetraLinha1;
            btnX.Click += AtribuirLetraLinha1;
            btnY.Click += AtribuirLetraLinha1;
            btnZ.Click += AtribuirLetraLinha1;
            btnÇ.Click += AtribuirLetraLinha1;

            VerificarPalavraCorreta();
        }
        private void ReiniciarJogo(object? sender, EventArgs e)
        {
            jogo = new JogoDasPalavras();

            btnA.Click += AtribuirLetraLinha1;
            btnB.Click += AtribuirLetraLinha1;
            btnC.Click += AtribuirLetraLinha1;
            btnD.Click += AtribuirLetraLinha1;
            btnE.Click += AtribuirLetraLinha1;
            btnF.Click += AtribuirLetraLinha1;
            btnG.Click += AtribuirLetraLinha1;
            btnH.Click += AtribuirLetraLinha1;
            btnI.Click += AtribuirLetraLinha1;
            btnJ.Click += AtribuirLetraLinha1;
            btnK.Click += AtribuirLetraLinha1;
            btnL.Click += AtribuirLetraLinha1;
            btnM.Click += AtribuirLetraLinha1;
            btnN.Click += AtribuirLetraLinha1;
            btnO.Click += AtribuirLetraLinha1;
            btnP.Click += AtribuirLetraLinha1;
            btnQ.Click += AtribuirLetraLinha1;
            btnR.Click += AtribuirLetraLinha1;
            btnS.Click += AtribuirLetraLinha1;
            btnT.Click += AtribuirLetraLinha1;
            btnU.Click += AtribuirLetraLinha1;
            btnV.Click += AtribuirLetraLinha1;
            btnW.Click += AtribuirLetraLinha1;
            btnX.Click += AtribuirLetraLinha1;
            btnY.Click += AtribuirLetraLinha1;
            btnZ.Click += AtribuirLetraLinha1;
            btnÇ.Click += AtribuirLetraLinha1;

            VerificarPalavraCorreta();

            foreach (Button botao in pnlBotoes.Controls)
            {
                botao.Enabled = true;
                botao.BackColor = Color.Empty;
            }
        }
        private void FinalizarJogo()
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                botao.Enabled = true;
                botao.BackColor = Color.Empty;
            }
        }

        private void VerificarPalavraCorreta()
        {
            if (jogo.palavraSecreta == palavraImputada1)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            if (jogo.palavraSecreta != palavraImputada1)
            {
                foreach (Char c in palavraImputada1)
                {
                    if (jogo.palavraSecreta[0] == palavraImputada1[0])
                    {
                        txt1A.BackColor = Color.Green;
                    }
                    if (jogo.palavraSecreta[1] == palavraImputada1[1])
                    {
                        txt1B.BackColor = Color.Green;
                    }
                    if (jogo.palavraSecreta[2] == palavraImputada1[2])
                    {
                        txt1C.BackColor = Color.Green;
                    }
                    if (jogo.palavraSecreta[3] == palavraImputada1[3])
                    {
                        txt1D.BackColor = Color.Green;
                    }
                    if (jogo.palavraSecreta[4] == palavraImputada1[4])
                    {
                        txt1E.BackColor = Color.Green;
                    }
                }
            }
        }

        private void AtribuirLetraLinha1(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            if (string.IsNullOrEmpty(txt1A.Text))
            {
                txt1A.Text = botaoClicado.Text;
                //botaoClicado.BackColor = Color.Green;
                //txt1A.BackColor = Color.Green;
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1E.Text))
            {
                palavraImputada1 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
                palavraImputada1 = palavraImputada1.ToLower();
                VerificarPalavraCorreta();
                return;
            }
            //if (!string.IsNullOrEmpty(txt2E.Text))
            //{
            //    palavraImputada2 = txt2A.Text + txt2B.Text + txt2C.Text + txt2D.Text + txt2E.Text;
            //    return;
            //}
            //if (!string.IsNullOrEmpty(txt3E.Text))
            //{
            //    palavraImputada3 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
            //    return;
            //}
            //if (!string.IsNullOrEmpty(txt4E.Text))
            //{
            //    palavraImputada4 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
            //    return;
            //}
            //if (!string.IsNullOrEmpty(txt5E.Text))
            //{
            //    palavraImputada5 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
            //    return;
            //}
            //if (!string.IsNullOrEmpty(txt6E.Text))
            //{
            //    palavraImputada6 = txt1A.Text + txt1B.Text + txt1C.Text + txt1D.Text + txt1E.Text;
            //    return;
            //}
        }

        //private void FinalizarJogo()
        //{
        //    //bool jogadorPerdeu = jogoDasPalavras.JogadorPerdeu();

        //    //if (jogadorPerdeu)
        //    //lblMensagemFinal.ForeColor = Color.DarkRed;
        //    //else
        //    //lblMensagemFinal.ForeColor = Color.DarkGreen;

        //    pnlBotoes.Enabled = false;

        //    //lblMensagemFinal.Text = jogoDasPalavras.mensagemFinal;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1E.Text))
            {
                LimparBotaoClicado();
                txt1E.Text = txt1E.Text.Substring(0, txt1E.Text.Length - 1);
                txt1E.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1D.Text))
            {
                foreach (Button botao in pnlBotoes.Controls)
                {
                    if (botao.Text == txt1D.Text)
                    {
                        botao.BackColor = Color.Empty;
                    }
                }
                txt1D.Text = txt1D.Text.Substring(0, txt1D.Text.Length - 1);
                txt1D.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1C.Text))
            {
                foreach (Button botao in pnlBotoes.Controls)
                {
                    if (botao.Text == txt1C.Text)
                    {
                        botao.BackColor = Color.Empty;
                    }
                }
                txt1C.Text = txt1C.Text.Substring(0, txt1C.Text.Length - 1);
                txt1C.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1B.Text))
            {
                foreach (Button botao in pnlBotoes.Controls)
                {
                    if (botao.Text == txt1B.Text)
                    {
                        botao.BackColor = Color.Empty;
                    }
                }
                txt1B.Text = txt1B.Text.Substring(0, txt1B.Text.Length - 1);
                txt1B.BackColor = Color.Empty;
                return;
            }
            if (!string.IsNullOrEmpty(txt1A.Text))
            {
                foreach (Button botao in pnlBotoes.Controls)
                {
                    if (botao.Text == txt1A.Text)
                    {
                        botao.BackColor = Color.Empty;
                    }
                }
                txt1A.Text = txt1A.Text.Substring(0, txt1A.Text.Length - 1);
                txt1A.BackColor = Color.Empty;
                return;
            }
        }

        private void LimparBotaoClicado()
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                if (botao.Text == txt1E.Text)
                {
                    botao.BackColor = Color.Empty;
                }
            }
        }
    }
}