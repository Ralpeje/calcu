using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void leerNumero(string numero)
        {
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            Historial.Text = cajaResultado.Text + " + ";
            cajaResultado.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                Historial.Text += valor2 + " = ";
                double resultado = valor1 + valor2;
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }
    }
}
