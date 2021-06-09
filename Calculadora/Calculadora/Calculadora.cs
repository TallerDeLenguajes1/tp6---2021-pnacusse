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
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbxPantalla.Clear();
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "3";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + ",";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxPantalla.Text);
            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxPantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    tbxPantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxPantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    tbxPantalla.Text = Div.ToString();
                    break;
            }
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            if (tbxPantalla.Text.Length == 1)
                tbxPantalla.Text = "";
            else
                tbxPantalla.Text = tbxPantalla.Text.Substring(0, tbxPantalla.Text.Length - 1);
        }
    }
}
