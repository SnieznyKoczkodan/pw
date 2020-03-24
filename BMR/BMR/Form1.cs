using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            double wzrost = Convert.ToDouble(textBox1.Text);

            double waga = Convert.ToDouble(textBox2.Text);

            double wiek = Convert.ToDouble(textBox3.Text);




            if (radioButton1.Checked)
            {
                double wynik = ((9.99 * waga) + (6.25 * wzrost) - ((4.92 * wiek) + 5));
                label1.Text = wynik.ToString();
            }
            else
            {
                double wynik2 = ((9.99 * waga) + (6.25 * wzrost) - ((4.92 * wiek) - 161));
                label1.Text = wynik2.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
       // Mężczyźni: [9, 99 x masa ciała(kg)] + [6, 25 x wzrost(cm)] - [4, 92 x wiek(lata)] + 5
       // Kobiety: [9, 99 x masa ciała(kg)] + [6, 25 x wzrost(cm)] - [4, 92 x wiek(lata)] – 161

            }
        }
    }

