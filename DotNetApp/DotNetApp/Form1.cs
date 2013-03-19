using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotNetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // инициализация формы
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // кнопка выхода из приложения
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, d;
                a = Convert.ToDouble(textBox1.Text); //коэффициент а
                b = Convert.ToDouble(textBox2.Text); // коэффициент b
                c = Convert.ToDouble(textBox3.Text); // коэффициент с
                d = (b * b) - 4 * (a * c); // дискриминант

                if (d > 0) // если дискриминант больше нуля
                {
                    double x1 = ((-1) * (b) + Math.Sqrt(d)) / (2 * a); // корень первый
                    double x2 = ((-1) * (b) - Math.Sqrt(d)) / (2 * a); // корень второй
                    textBox4.Text = "X1= " + Convert.ToString(x1); // вывод в текстбокс
                    textBox4.Text += ", X2= ";
                    textBox4.Text += Convert.ToString(x2);
                }
                else
                    if (d == 0) // если дискриминант равен нулю
                    {
                        double x = (-1) * (b) / 2 * a; // вычисляется только один корень
                        textBox4.Text = Convert.ToString(x); // вывод в текстбокс
                    }
                    else
                    {
                        textBox4.Text = "Корни комплексные"; // если не выполняется два пердыдущих условия, то ничего вычислять не надо, корни комплексные
                    }
            }
            catch (Exception exc) // инициализация блока исключений при возникновении ошибки
            {
                MessageBox.Show(exc.ToString(), "Ошибка!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

    }
}

