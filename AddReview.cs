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
    public partial class AddReview : UserControl
    {
        public string ID;
        public string mediaType;

        public AddReview(string id, string mediaType)
        {
            InitializeComponent();
            this.ID = id;
            this.mediaType = mediaType;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            if (mediaType.Equals("movie"))
            {
                sql = "INSERT INTO review(id_review, title, score, written_review, movie_id_movie, television_id_television) " +
                      "VALUES(default, '" + textBox1.Text + "', " + numericUpDown1.Value + ", '" + richTextBox1.Text + "', " + ID + ", null)";
            }
            else if (mediaType.Equals("television"))
            {
                sql = "INSERT INTO review(id_review, title, score, written_review, movie_id_movie, television_id_television) " +
                      "VALUES(default, '" + textBox1.Text + "', " + numericUpDown1.Value + ", '" + richTextBox1.Text + "', null, " + ID + ")";
            }

            command = new MySqlCommand(sql, cnn);

            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls[ParentForm.Controls.Count - 2].Visible = true;
            this.ParentForm.Controls.RemoveAt(ParentForm.Controls.Count - 1);
        }
    }
}
