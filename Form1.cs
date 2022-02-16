using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "")
            {
                valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVIDE";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para dividir.");
            }
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "")
            {
                valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "VEZES";
                lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para multiplicar.");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "MENOS")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "VEZES")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" )
            {
                valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MENOS";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para subtrair.");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }   

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para somar.");
            }
        }
    }
}
