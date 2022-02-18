using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaReviewSystem
{
    public partial class PersonDetails : UserControl
    {
        string ID;
        string personType;
        string fullName;

        public PersonDetails(string id, string personType, string fullName, string description)
        {
            InitializeComponent();
            ID = id;
            this.personType = personType;
            this.fullName = fullName;
            richTextBox1.Text = description;
            label1.Text = fullName.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls[ParentForm.Controls.Count - 2].Visible = true;
            this.ParentForm.Controls.RemoveAt(ParentForm.Controls.Count - 1);
        }

        private void DeleteEntry(object sender, EventArgs e)
        {

        }
    }
}
