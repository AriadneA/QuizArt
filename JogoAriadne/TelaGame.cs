using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace JogoAriadne
{
    public partial class TelaGame : Form
    {
        int tentativas = 0;
        int level = 1;
        int numeroPremiado;
        int palpite;
        int semente;
        Jogo sorteio = new Jogo();
        Jogo verifica = new Jogo();
        int numero;
        Random random;
        SpeechSynthesizer voz = new SpeechSynthesizer();

        public TelaGame()
        {
            InitializeComponent();
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 1;
            label3.Text = "De 1 a 100";
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 2;
            label3.Text = "De 1 a 500";
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 3;
            label3.Text = "De 1 a 1000";
        }
        private void TelaGame_Load(object sender, EventArgs e)
        {
            label4.Text = "Escolha um nível";
            this.AcceptButton = button1;
            random = new Random(tentativas * 1365);
            numeroPremiado = sorteio.sorteiaNumero(level, random.Next(10000 - tentativas));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Realmente Sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tentativas++;
            palpite = Convert.ToInt32(textBox1.Text);
            if (numeroPremiado == palpite)
            {
                voz.Speak("Acertou");
                MessageBox.Show("Parabéns você acertou com " + tentativas.ToString() + " Tentativas.");
                label1.Text = numeroPremiado.ToString();
                voz.Volume = 100;
                textBox1.Clear();
            }
            else
            {
                if (numeroPremiado > palpite)
                {
                    voz.Volume = 100;
                    voz.Speak("Errou! número maior");
                    MessageBox.Show("O Número Sorteado é MAIOR.");
                    textBox1.Text = "";
                }
                else
                {
                    voz.Volume = 100;
                    voz.Speak("Errou! número menor");
                    MessageBox.Show("O Número Sorteado é MENOR.");
                    textBox1.Text = "";
                }
            }



        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Iniciar um Novo Jogo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                random = new Random(tentativas);
                numeroPremiado = sorteio.sorteiaNumero(level, random.Next(100001 - tentativas));
                label1.Text = "?";
                tentativas = 0;
            }
            else
            {

            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advinhe o número escondido.\n\rEscolha um nível:\n\rSe o nível escolhido for o facil = números de 1 a 100;\n\rSe for medio = número de 1 a 500;\n\rSe for o dificil = numeros de 1 a 1000.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            semente++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
