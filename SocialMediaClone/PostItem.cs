using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaClone
{
    public partial class PostItem : UserControl
    {
        public PostItem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            
            comment com = new comment();
            com.Show();
        }
    }
}
