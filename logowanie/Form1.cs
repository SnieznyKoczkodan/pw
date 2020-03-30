using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] LOGIN = new string[2] { "user", "user123" };    
            String[] HASŁO = new string[2] { "user", "user123" }; 
            Form2 NOWE_OKNO_F2= new Form2(); 
            String LOGIN_WPISANE = textBox1.Text;
            String HASŁO_WPISANE = textBox2.Text;

            for (int i = 0; i <= 1; i++)
            { 
                if (LOGIN_WPISANE == LOGIN[i])
                {
                    for(int k=0; k<=1; k++) 
                    {
                        if (HASŁO_WPISANE== LOGIN[k]) 
                        {
                            NOWE_OKNO_F2.Show();
                        }
                    }
                }

            }

        }
    }
}
