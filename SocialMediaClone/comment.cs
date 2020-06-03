using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaClone
{
    public partial class comment : Form
    {
        public comment()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timelineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
