
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Diagnostics.Metrics;

namespace JogoDasPalavras.WinFormsApp
{
    public partial class Form1 : Form
    {
        private JogoDasPalavras jogo;

        public int textBoxesPreenchidas = 0;

        private List<Button> listaBotoes = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            jogo = new JogoDasPalavras();
        }

        private int contadorPalavra = 1;

        private List<string> palavrasImputadas = new List<string>();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tblTextBoxes.Controls.Count < 5)
            {
                MessageBox.Show("Preencha todas as letras antes de pressionar Enter.");
                return;
            }

            List<TextBox> textBoxes = tblTextBoxes.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex).ToList();

            string palavraImputada = "";

            string ultimos5Caracteres = "";

            foreach (TextBox textBox in textBoxes)
            {
                palavraImputada += textBox.Text;
            }
            if (palavrasImputadas.Count % 5 != 0)
            {
                ultimos5Caracteres = palavraImputada.Substring(palavraImputada.Length - 5);
            }
            if (palavrasImputadas.Count % 5 == 0)
            {
                ultimos5Caracteres = palavraImputada;
            }

            palavrasImputadas.Add(ultimos5Caracteres);

            VerificarPalavra(ultimos5Caracteres);

            if (jogo.palavraSecreta == ultimos5Caracteres)
            {
                Close();
            }
            else
            {
                FinalizarJogoPerdeu(ultimos5Caracteres);
                textBoxesPreenchidas = 0;
            }
        }

        private void VerificarPalavra(string palavraImputada)
        {
            if (jogo.palavraSecreta == palavraImputada)
            {
                MessageBox.Show("Parabéns, você ganhou!");
                pnlBotoes.Enabled = false;
                return;
            }
            for (int i = 0; i < palavraImputada.Length; i++)
            {
                if (palavraImputada[i] == jogo.palavraSecreta[i])
                {
                    tblTextBoxes.Controls["txt1" + (char)('A' + i)].BackColor = Color.Green;
                    PintarBotaoClicado((Button)pnlBotoes.Controls["btn" + palavraImputada[i]], Color.Green);
                }
                else if (jogo.palavraSecreta.Contains(palavraImputada[i]))
                {
                    tblTextBoxes.Controls["txt1" + (char)('A' + i)].BackColor = Color.Yellow;
                    PintarBotaoETxtBoxClicado(palavraImputada[i], Color.Yellow);
                }
                else
                {
                    tblTextBoxes.Controls["txt1" + (char)('A' + i)].BackColor = Color.LightGray;
                    PintarBotaoETxtBoxClicado(palavraImputada[i], Color.LightGray);
                }
            }
        }

        private void FinalizarJogoPerdeu(string palavraImputada)
        {
            MessageBox.Show("Você perdeu...");
            pnlBotoes.Enabled = false;
            Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = tblTextBoxes.Controls.OfType<TextBox>().ToList();
            textBoxes.Sort((t1, t2) => t2.TabIndex.CompareTo(t1.TabIndex));
            if (textBoxesPreenchidas != 0)
            {
                foreach (TextBox textBox in textBoxes)
                {
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = "";
                        textBoxesPreenchidas--;
                        break;
                    }
                }
            }
        }

        private void PintarBotaoClicado(Button botao, Color cor)
        {
            botao.BackColor = cor;
        }

        private void PintarBotaoETxtBoxClicado(Char c, Color cor)
        {
            foreach (TextBox txt in tblTextBoxes.Controls)
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

        private void btnA_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnO_Click_1(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            TextBox primeiraTextBoxVazia = null;

            foreach (TextBox t in tblTextBoxes.Controls)
            {
                if (textBoxesPreenchidas >= 5)
                {
                    break;
                }
                if (t.Text == "")
                {
                    if (primeiraTextBoxVazia == null || t.TabIndex < primeiraTextBoxVazia.TabIndex)
                    {
                        primeiraTextBoxVazia = t;
                    }
                }
            }

            if (primeiraTextBoxVazia != null)
            {
                primeiraTextBoxVazia.Text = botaoClicado.Text;
                textBoxesPreenchidas++;
            }
        }
    }
}