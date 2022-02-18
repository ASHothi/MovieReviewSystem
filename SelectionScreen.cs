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

        public SelectionScreen()
        {
            InitializeComponent();
            RBMovie.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSearchTarget();

            string connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            string sqlSelectAll = "";

            switch (searchTarget)
            {
                case "movie":
                    sqlSelectAll = "SELECT title FROM movie";
                    if (!String.IsNullOrEmpty(textBox1.Text))
                    {
                        sqlSelectAll += " WHERE title = '" + textBox1.Text + "'" ;
                    }
                    break;
                case "television":
                    sqlSelectAll = "SELECT title FROM television";
                    if (!String.IsNullOrEmpty(textBox1.Text))
                    {
                        sqlSelectAll += " WHERE title = '" + textBox1.Text + "'";
                    }
                    break;
                case "actor":
                    sqlSelectAll = "SELECT * FROM actor";
                    break;
                case "writer":
                    sqlSelectAll = "SELECT * FROM writer";
                    break;
                case "director":
                    sqlSelectAll = "SELECT * FROM director";
                    break;
                default:
                    break;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //this.ParentForm.Controls[ParentForm.Controls.Count - 2].Visible = true;
            this.ParentForm.Controls.RemoveAt(ParentForm.Controls.Count - 1);
            panel.Show();
            this.Visible = false;
        }

        private string MovieDesc(MySqlDataReader dataReader)
        {
            string output = "";

            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(2))
                {
                    output += "Duration: " + dataReader.GetString(2);
                }
                else
                {
                    output += "Duration: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(3))
                {
                    output += "Release Date: " + dataReader.GetString(3);
                }
                else
                {
                    output += "Release Date: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(4))
                {
                    output += "Age Rating: " + dataReader.GetString(4);
                }
                else
                {
                    output += "Age Rating: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(5))
                {
                    output += "Description: " + dataReader.GetString(5);
                }
                else
                {
                    output += "Description: UNKOWN";
                }
            }

            return output;
        }

        private string TelevisionDesc(MySqlDataReader dataReader)
        {
            string output = "";

            while (dataReader.Read())
            {
                if (!dataReader.IsDBNull(2))
                {
                    output += "Episode count: " + dataReader.GetString(2);
                }
                else
                {
                    output += "Episode count:: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(3))
                {
                    output += "Season count: " + dataReader.GetString(3);
                }
                else
                {
                    output += "Season count:: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(4))
                {
                    output += "Release Date: " + dataReader.GetString(4);
                }
                else
                {
                    output += "Release Date: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(5))
                {
                    output += "Age Rating: " + dataReader.GetString(5);
                }
                else
                {
                    output += "Age Rating: UNKOWN";
                }

                output += "\n";

                if (!dataReader.IsDBNull(6))
                {
                    output += "Description: " + dataReader.GetString(6);
                }
                else
                {
                    output += "Description: UNKOWN";
                }
            }

            return output;
        }

        public void SetSearchTarget()
        {
            if (RBMovie.Checked == true)
            {
                searchTarget = "movie";
            }
            else if (RBTV.Checked == true)
            {
                searchTarget = "television";
            }
            else if (RBActor.Checked == true)
            {
                searchTarget = "actor";
            }
            else if (RBWriter.Checked == true)
            {
                searchTarget = "writer";
            }
            if (RBDirector.Checked == true)
            {
                searchTarget = "director";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connetionString = @"Data Source=localhost;Initial Catalog=reviewdb;User ID=root;Password=root";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM " + searchTarget + " WHERE title = '" + dataGridView1.CurrentCell.Value.ToString() + "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            if (searchTarget.Equals("movie"))
            {
                Output = MovieDesc(dataReader);
            }
            else if (searchTarget.Equals("television"))
            {
                Output = TelevisionDesc(dataReader);
            }

            MediaDetails control = new MediaDetails(Output, searchTarget, "" + dataReader.GetString(0), "" + dataReader.GetString(1).ToUpper());
            control.Dock = DockStyle.Fill;
            Parent.Controls.Add(control);
            this.Visible = false;

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
