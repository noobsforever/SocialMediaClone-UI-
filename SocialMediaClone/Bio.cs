using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
namespace SocialMediaClone
{
    public partial class Bio : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Bio()
        {
            
            InitializeComponent();
            firstNameLabel.Text = User.firstName;
            lastNameLabel.Text = User.lastName;
            genderLabel.Text = User.gender;
            dobLabel.Text = User.dob;
            emailLabel.Text = User.email;
            //reputationLabel.Text = User.reputation.ToString();
            //firstNameLabel2.Text = User.firstName + " " + User.lastName;
            relationLabel.Text = User.relation;
            phoneLabel.Text = User.phone;
            
        }

        private void firstNameEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bio_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
