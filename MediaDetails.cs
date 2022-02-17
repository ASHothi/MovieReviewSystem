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
    public partial class MediaDetails : UserControl
    {
        string mediaType;
        string id;

        public MediaDetails(string details, string mediaType, string id, string title)
        {
            InitializeComponent();
            this.mediaType = mediaType;
            richTextBox1.Text = details;
            this.id = id;
            label1.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReview control = new AddReview(id, mediaType);
            control.Dock = DockStyle.Fill;
            this.ParentForm.Controls.Add(control);
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ParentForm.Controls[ParentForm.Controls.Count - 2].Visible = true;
            this.ParentForm.Controls.RemoveAt(ParentForm.Controls.Count - 1);
        }
    }
}
