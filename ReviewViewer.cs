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
    public partial class ReviewViewer : UserControl
    {
        string ID;
        string mediaType;

        public ReviewViewer(string id, string mediaType)
        {
            InitializeComponent();
            ID = id;
            this.mediaType = mediaType;
            FillData();
        }

        private void ReviewViewer_Load(object sender, EventArgs e)
        {

        }

        private void FillData()
        {            
            string connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            string sqlSelectAll = "";

            if (mediaType.Equals("movie"))
            {
                sqlSelectAll = "SELECT title, score, written_review FROM review WHERE movie_id_movie = " + ID;
            }
            else if (mediaType.Equals("television"))
            {
                sqlSelectAll = "SELECT title, score, written_review FROM review WHERE television_id_television = " + ID;
            }

            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, cnn);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;

            MyDA.Dispose();
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls[ParentForm.Controls.Count - 2].Visible = true;
            this.ParentForm.Controls.RemoveAt(ParentForm.Controls.Count - 1);
        }
    }
}
