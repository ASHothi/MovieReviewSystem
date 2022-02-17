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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox3.Text;
            string runTime = textBox2.Text;
            string releaseDate = textBox1.Text;
            string age_rating = textBox4.Text;
            string description = richTextBox1.Text;

            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "INSERT INTO movie(id_movie, title, run_time, release_date, age_rating, description) VALUES(default, '" + title + "', '" 
                + runTime + "', '" + releaseDate + "', '" + age_rating + "', '" + description + "')";

            command = new MySqlCommand(sql, cnn);

            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Clear();
        }
    }
}
