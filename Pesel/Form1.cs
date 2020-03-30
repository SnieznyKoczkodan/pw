using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "PESEL:";
            String TYMCZAS = textBox1.Text; //przechować chwilowo wartość 
            int[] PESEL_INT = new int[11]; //wartosć liczb
            int SUMA = 0; 
            int[] WAGA_LICZB = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };  
            char[] PESEL = TYMCZAS.ToCharArray();
            int OST = 0; //ostatnia cyfra w peselu
            int KONTROLA = 0; 
          


            for (int i = 0; i < 11; i++)
            {
                PESEL_INT[i] = int.Parse(PESEL[i].ToString());
                label1.Text += PESEL[i].ToString();
            }

            for (int i = 0; i < 10; i++)
            {
                SUMA += (PESEL_INT[i]) * (WAGA_LICZB[i]);
            }


            OST = SUMA % 10;
            KONTROLA = 10 - OST;
            if (KONTROLA != PESEL_INT[10])
            {
                label1.Text += "BŁĄD";
            }
            else
            {
                label1.Text += "DOBRZE";
            }

        }

    }
}

