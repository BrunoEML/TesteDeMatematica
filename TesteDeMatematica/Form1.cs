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
        Random Random = new Random();

        int valorSom1, valorSom2; //Armazenarão os valores para a soma
        int valorSub1, valorSub2; //Armazenarão os valores para a subtração
        int valorMul1, valorMul2; //Armazenarão os valores para a multiplicação
        int valorDiv1, valorDiv2; //Armazenarão os valores para a divisão

        public Form1()
        {
            InitializeComponent();
        }

        public void ComecarQuiz()
        {
            //Atribuindo valores aleatórios para as variáveis
            valorSom1 = Random.Next(50);
            valorSom2 = Random.Next(50);

            //Convertendo os valores para strings e mostrandos eles nos Labels
            lblSoma1.Text = valorSom1.ToString();
            lblSoma2.Text = valorSom2.ToString();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Garante que os valores dos resultado serão iniciados em zero
            nudSoma.Value = 0;
            nudSubtracao.Value = 0;
            nudMultiplicacao.Value = 0;
            nudDivisao.Value = 0;

            //Garante que o quiz não será iniciado novamente durante o jogo
            btnIniciar.Enabled = false;

            //Começa o quiz
            ComecarQuiz();
        }
    }
}
