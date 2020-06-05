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
            this.genderEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            firstNameEdit.Visible = true;
            lastNameEdit.Visible = true;
            genderEdit.Visible = true;
            dobEdit.Visible = true;
            relationEdit.Visible = true;
            phoneEdit.Visible = true;
            saveButton.Visible = true;
            firstNameLabel.Visible = false;
            
            lastNameLabel.Visible = false;
            genderLabel.Visible = false;
            dobLabel.Visible = false;
            phoneLabel.Visible = false;
            relationLabel.Visible = false;
            firstNameEdit.Text = firstNameLabel.Text;
            lastNameEdit.Text = lastNameLabel.Text;
            genderEdit.Text = genderLabel.Text;
            DateTime DT = DateTime.Parse(dobLabel.Text);
            dobEdit.Value = DT;
            relationEdit.Text = relationLabel.Text;
            phoneEdit.Text = phoneLabel.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string dobText = dobEdit.Value.ToString();
            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("email", emailLabel.Text);
            var update = Builders<BsonDocument>.Update.Set("firstName", firstNameEdit.Text).Set("lastName", lastNameEdit.Text).Set("gender", genderEdit.Text).Set("dob", dobEdit.Text).Set("phone", phoneEdit.Text).Set("relation", relationEdit.Text);
            var result = collection.UpdateOne(filter, update);
            var result2 = collection.Find(filter).ToList();
            var user1 = result2[0];

            User.firstName = user1[1].ToString();
            User.lastName = user1[2].ToString();
            User.gender = user1[3].ToString();
            User.dob = user1[4].ToString();
            User.email = user1[5].ToString();
            User.password = user1[6].ToString();
            User.username = user1[7].ToString();
            User.reputation = user1[8].ToInt32();
            User.phone = user1[10].ToString();
            User.relation = user1[11].ToString();
            this.Hide();
            ParentForm.Hide();
            Menu menu = new Menu();
            menu.OpenChildForm(new Bio());
            menu.Show();
        }
    }
}
