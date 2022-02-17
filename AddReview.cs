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
    }
}
