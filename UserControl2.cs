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
    public partial class UserControl2 : UserControl
    {
        public Panel panel;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string title = textBox2.Text;

            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "DELETE FROM movie WHERE id_movie = '" + id + "'";

            command = new MySqlCommand(sql, cnn);

            adapter.DeleteCommand = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
    }
}
