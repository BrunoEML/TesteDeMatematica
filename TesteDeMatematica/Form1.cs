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

        private void Responder_enter(object sender, EventArgs e)
        {
            // Seleciona toda a resposta que está na caixa NumericUpDown
            NumericUpDown answerBox = sender as NumericUpDown;

            //Caso tenha algo na nud, obtemos o tamanho dete valor e o "selecionamos"
            //Isto é útil para facilitar a inserção da resposta, selecionando um valor preexistente para que
            //seja inteiramente substituida pelo valor digitado e não apenas inserida junto a ele
            if (answerBox != null)
            {
                int tamanhoResposta = answerBox.Value.ToString().Length;
                answerBox.Select(0, tamanhoResposta);
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
            valorSub1 = random.Next(100);
            valorSub2 = random.Next(0, valorSub1); //Coloca Sub1 como máximo possível, evitando respostas negativas
            valorMul1 = random.Next(10);
            valorMul2 = random.Next(10); 
            valorDiv2 = random.Next(1, 10); //Impede a divisão por zero
            int DivTemp = random.Next(10);
            valorDiv1 = DivTemp * valorDiv2; //Garante que resultado da divisao sera um inteiro


            //Convertendo os valores para strings e mostrandos eles nos Labels
            lblSoma1.Text = valorSom1.ToString();
            lblSoma2.Text = valorSom2.ToString();
            lblSubtracao1.Text = valorSub1.ToString();
            lblSubtracao2.Text = valorSub2.ToString();
            lblMultiplicacao1.Text = valorMul1.ToString();
            lblMultiplicacao2.Text = valorMul2.ToString();
            lblDivisao1.Text = valorDiv1.ToString();
            lblDivisao2.Text = valorDiv2.ToString();

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
            if ((valorSom1 + valorSom2 == nudSoma.Value) &&
                (valorSub1 - valorSub2 == nudSubtracao.Value) &&
                (valorMul1 * valorMul2 == nudMultiplicacao.Value) &&
                (valorDiv1 / valorDiv2 == nudDivisao.Value))
                return true;
            else
                return false;
        }
    }
}
