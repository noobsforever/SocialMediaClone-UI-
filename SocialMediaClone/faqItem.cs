using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace SocialMediaClone
{
    public partial class faqItem : UserControl
    {
       
        #region properties
        private string question;
        private string answer;

        [Category("Custom Props")]
        public string Question
        {
            get { return question; }
            set { question = value; questionLabel.Text = value; }
        }
        public string Answer
        {
            get { return answer; }
            set { answer = value; answerLabel.Text = value; }
        }



        #endregion
        public faqItem()
        {
            InitializeComponent();
        }

        private void faqItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
