using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeMatematica
{
    public partial class Form1 : Form
    {
        //Um objeto do tipo Ramdom será usado para gerar números aleatórios.
        Random random = new Random();

        int valorSom1, valorSom2; //Armazenarão os valores para a soma
        int valorSub1, valorSub2; //Armazenarão os valores para a subtração
        int valorMul1, valorMul2; //Armazenarão os valores para a multiplicação
        int valorDiv1, valorDiv2; //Armazenarão os valores para a divisão

        int tempoRestante; //Armazenará quantos segundos faltam, para que possa ser exibido na tela

        //Esta função será executada a cada 1000 milisegundos (1  segundo)
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if(ConferirResposta())
            {
                //Caso todas as respostas estejam corretas encerra o jogo
                lblTempo.ForeColor = Color.Green;
                tmrTimer.Stop();
                lblTempo.Text = "Parabéns!!! :)";
                MessageBox.Show("Você conseguiu terminar a tempo.", "Parabéns Einstein!!!"); //Exibe as mensagens em uma caixa de diálogo
                btnIniciar.Enabled = true;
            }
            else if (tempoRestante > 0)   //Atualiza a contagem na tela a cada segundo
            {
                if (tempoRestante == 6) lblTempo.ForeColor = Color.Red;

                tempoRestante--;
                lblTempo.Text = tempoRestante + " segundos";
            }
            else
            {
                //  nudSoma.BackColor = Color.Red;
                //  nudSoma.Value = valorSom1 + valorSom2; Marcar de cores diferente os certos e errados
                tmrTimer.Stop();
                lblTempo.Text = "Tempo Acabado";
                MessageBox.Show("Você não conseguiu terminar a tempo.", "Mais sorte na próxima vez  :("); //Exibe as mensagens em uma caixa de diálogo
                btnIniciar.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ComecarQuiz()
        {
            //Garante que os valores dos resultado serão iniciados em zero
            nudSoma.Value = 0;
            nudSubtracao.Value = 0;
            nudMultiplicacao.Value = 0;
            nudDivisao.Value = 0;

            //Atribuindo valores aleatórios para as variáveis
            valorSom1 = random.Next(50);
            valorSom2 = random.Next(50);

            //Convertendo os valores para strings e mostrandos eles nos Labels
            lblSoma1.Text = valorSom1.ToString();
            lblSoma2.Text = valorSom2.ToString();

            //Inicializa o timer e define o tempo de conatgem em 30 (segundos)
            tempoRestante = 30;
            lblTempo.Text = "30 segundos";
            tmrTimer.Start();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Garante que o quiz não será iniciado novamente durante o jogo
            btnIniciar.Enabled = false;

            ComecarQuiz(); //Começa o quiz
        }

        private bool ConferirResposta()
        {
            if ((valorSom1 + valorSom2 == nudSoma.Value))
                return true;
            else
                return false;
        }
    }
}
