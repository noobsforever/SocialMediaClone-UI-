using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace SocialMediaClone
{
    public partial class Registration : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
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
            User.friends.Clear();
            User.friends2.Clear();
            this.genderRegister.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void registerConfirmButton_Click(object sender, EventArgs e)
        {
            bool pass = true;
            string dobText = dobRegister.Value.ToString();
            var collection = database.GetCollection<BsonDocument>("users");
            var builder1 = Builders<BsonDocument>.Filter;
            var filter1 = builder1.Or(builder1.Eq("email", emailRegister.Text), builder1.Eq("username", usernameRegister.Text));
            var result1 = collection.Find(filter1).ToList();
            if (result1.Count > 0)
            {
                MessageBox.Show("A user with the same email or username already exists...");
                this.Close();
                Registration register = new Registration();
                register.Show();
                pass = false;
            }
            if (pass)
            {
                var user = new BsonDocument
            {
                {"firstName", firstNameRegister.Text },
                {"lastName", lastNameRegister.Text },
                {"gender", genderRegister.Text },
                {"dob", dobText },
                {"email", emailRegister.Text },
                {"password", passwordRegister.Text },
                {"username", usernameRegister.Text },
                {"reputation",30 },
                {"friends", new BsonArray {""} },
                {"phone","" },
                {"relation","single" },


            };
                collection.InsertOne(user);
                MessageBox.Show("Registration Successful");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void gotoLoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
