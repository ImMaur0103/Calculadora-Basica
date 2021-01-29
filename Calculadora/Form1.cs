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
        bool funcion = false;
        double Multiplicacion;
        double Division;
        double Suma;
        double Resta;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Biemvenido a la calculadora");
            
        }

        void multiplicacion(double a, double b)
        {

            Multiplicacion = a * b;
        }
        void divicion(double a, double b)
        {
            Division = a / b;
        }
        void suma(double a, double b)
        {
            Suma = a + b;
        }
        void resta(double a, double b)
        {
            Resta = a - b;
        }

        double multi(double a ,double b)
        {
            Multiplicacion = a * b;
            return Multiplicacion;
        }
        double divi(double a, double b)
        {
            Multiplicacion = a / b;
            return Division;
        }
        double adicion(double a, double b)
        {
            Multiplicacion = a + b;
            return Suma;
        }
        double sustraccion(double a, double b)
        {
            Multiplicacion = a - b;
            return Resta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcion)
                {
                    label3.Text = Convert.ToString(multi(double.Parse(textBox1.Text), double.Parse(textBox2.Text)));
                }
                else
                {
                    multiplicacion(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    label3.Text = Multiplicacion.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcion)
                {
                    label3.Text = Convert.ToString(divi(double.Parse(textBox1.Text), double.Parse(textBox2.Text)));
                }
                else
                {
                    divicion(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    label3.Text = Division.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcion)
                {
                    label3.Text = Convert.ToString(adicion(double.Parse(textBox1.Text), double.Parse(textBox2.Text)));
                }
                else
                {
                    suma(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    label3.Text = Suma.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcion)
                {
                    label3.Text = Convert.ToString(sustraccion(double.Parse(textBox1.Text), double.Parse(textBox2.Text)));
                }
                else
                {
                    resta(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    label3.Text = Resta.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 == comboBox1.SelectedIndex)
            {
                funcion = true;
            }
            else if (1 == comboBox1.SelectedIndex)
            {
                funcion = false;
            }
        }
    }
}
