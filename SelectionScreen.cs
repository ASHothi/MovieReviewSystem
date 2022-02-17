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

namespace MediaReviewSystem
{
    public partial class SelectionScreen : UserControl
    {
        public Panel panel;
        public string searchTarget;

        public SelectionScreen(string searchTarget)
        {
            InitializeComponent();
            this.searchTarget = searchTarget;
            label2.Text = searchTarget + " search";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
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
               //Output += "ID: " + dataReader.GetString(0) + "\n" + "Title: " + dataReader.GetString(1) + "\n";


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

            if (searchTarget.Equals("movie"))
            {
                MediaDetails control = new MediaDetails(Output, searchTarget, "" + dataReader.GetString(0), "" + dataReader.GetString(1).ToUpper());
                control.Dock = DockStyle.Fill;
                Parent.Controls.Add(control);
                this.Visible = false;
               
            }

            //MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.Show();

            this.Visible = false;
        }
    }
}
