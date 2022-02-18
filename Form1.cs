using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaReviewSystem
{
    public partial class Form1 : Form
    {
        public List<Panel> listPanel = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program program = new Program();
            //listPanel.Add(panel1);
            //panel1.Hide();
            listPanel.Add(panel2);
            panel2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Output = "";

            string movie = textBox1.Text;

            sql = "SELECT * FROM movie WHERE title = '" + movie + "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            //ACADEMY DINOSAUR
            while (dataReader.Read())
            {
                Output += "Title: " + dataReader.GetString(1) + "\n"; 


                if (!dataReader.IsDBNull(2))
                {
                    Output += "Duration: " + dataReader.GetString(2);
                }
                else
                {
                    Output += "Duration: UNKOWN";
                }

                Output += "\n";

                if (!dataReader.IsDBNull(3))
                {
                    Output += "Release Date: " + dataReader.GetString(3);
                }
                else
                {
                    Output += "Release Date: UNKOWN";
                }

                Output += "\n";

                if (!dataReader.IsDBNull(4))
                {
                    Output += "Age Rating: " + dataReader.GetString(4);
                }
                else
                {
                    Output += "Age Rating: UNKOWN";
                }

                Output += "\n";

                if (!dataReader.IsDBNull(5))
                {
                    Output += "Description: " + dataReader.GetString(5);
                }
                else
                {
                    Output += "Description: UNKOWN";
                }
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string movie = textBox1.Text;

            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "INSERT INTO director(id_director, first_name, last_name, description) VALUES(default, 'chris', 'nolan', 'he made dark knight')";

            command = new MySqlCommand(sql, cnn);

            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "delete from director where first_name= 'chris'";

            command = new MySqlCommand(sql, cnn);

            adapter.DeleteCommand = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();*/
            UserControl2 control = new UserControl2();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.panel = panel2;
            panel2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "update director set description = 'he made inception' where first_name= 'chris'";

            command = new MySqlCommand(sql, cnn);

            adapter.UpdateCommand = new MySqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //movie
            SelectionScreen control = new SelectionScreen("movie");
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.panel = panel2;
            panel2.Hide();
            //panel1.BringToFront();
            //panel1.Show();
            //label1.Text = "search for movie";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl1 control = new UserControl1();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.panel = panel2;
            panel2.Hide();
            //panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SelectionScreen control = new SelectionScreen("television");
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.panel = panel2;
            panel2.Hide();
        }
    }
}
