using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cauculadora
{
    public partial class Form1 : Form
    {
        private StringBuilder expressao = new StringBuilder();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarNumero(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarNumero(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarNumero(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarNumero(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarNumero(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarNumero(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarNumero(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarNumero(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarNumero(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarNumero(0);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            {
                expressao.Clear();
                {
                    expressao.Clear();
            // Limpa a expressão
        txtResultado.Clear();
                }
            }

            return;
        }


        private void AdicionarNumero(int numero) //Metodo para Add numeros 
        {
         
            txtResultado.Text += numero.ToString();
            txtResultado.Text = expressao.ToString();


            expressao.Append(numero);
            txtResultado.Text = expressao.ToString();

        }
        private void AdicionarOperacao(char operacao) //Medoto para add opreçao
        {
            expressao.Append(operacao);
            txtResultado.Text = expressao.ToString();
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            AdicionarOperacao('+');
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarOperacao('-');
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            AdicionarOperacao('/');

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            AdicionarOperacao('.');
        }

        private void btnMultiplicAr_Click(object sender, EventArgs e)
        {
            AdicionarOperacao('*');
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable table = new DataTable();
                var resultado = table.Compute(expressao.ToString(), "");
                txtResultado.Text = resultado.ToString();
                expressao.Clear();


                txtResultado.Text = resultado.ToString();
                expressao.Clear();

            }
            catch (Exception)
            {
                txtResultado.Text = "Erro";
                expressao.Clear();

            }
            expressao.Clear();
        }
    }
}
