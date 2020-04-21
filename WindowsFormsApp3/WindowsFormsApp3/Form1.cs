using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "SELECT * FROM samochody";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            DataTable tabela = new DataTable();
            

            try
            {
                databaseConnection.Open();

                MySqlDataAdapter przejsciowka = new MySqlDataAdapter(commandDatabase);
                przejsciowka.Fill(tabela);
                dataGridView1.DataSource = tabela;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "INSERT INTO samochody (marka, model, pojemnosc, kolor, cena) VALUES (@parm1,@parm2,@parm3,@parm4,@parm5)";
            string _marka = textBox1.Text;
            string _model = textBox2.Text;
            int _pojemnosc = int.Parse(textBox3.Text);
            string _kolor = textBox4.Text;
            int _cena = int.Parse(textBox5.Text);



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@parm1",_marka);
            commandDatabase.Parameters.AddWithValue("@parm2", _model);
            commandDatabase.Parameters.AddWithValue("@parm3", _pojemnosc);
            commandDatabase.Parameters.AddWithValue("@parm4", _kolor);
            commandDatabase.Parameters.AddWithValue("@parm5", _cena);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=komis;";
            string query = "DELETE FROM samochody WHERE id = @parm1";

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@parm1", id);
           
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();


                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

