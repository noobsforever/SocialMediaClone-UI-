using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            bool pass1 = true;
            bool pass2 = true;
            string dobText = dobRegister.Value.ToString();
            var collection = database.GetCollection<BsonDocument>("users");
            var builder1 = Builders<BsonDocument>.Filter;
            var filter1 = builder1.Or(builder1.Eq("email", emailRegister.Text), builder1.Eq("username", usernameRegister.Text));
            var result1 = collection.Find(filter1).ToList();
            var i = 0;





            if (firstNameRegister.Text.Length == 0 || lastNameRegister.Text.Length == 0 || usernameRegister.Text.Length == 0 || emailRegister.Text.Length == 0 || passwordRegister.Text.Length == 0 || confirmPasswordRegister.Text.Length == 0)
            {
                MessageBox.Show("Please Fill All The Details");
                pass2 = false;
            }
            else
            {
                for (i = 0; i < firstNameRegister.Text.Length; i++)
                {
                    if (!(firstNameRegister.Text[i] >= 65 && firstNameRegister.Text[i] <= 90 || firstNameRegister.Text[i] >= 97 && firstNameRegister.Text[i] <= 122))
                    {
                        MessageBox.Show("First Name Cannot Have Special Characters.");
                        pass2 = false;
                        break;
                    }
                }
                if (i == firstNameRegister.Text.Length)
                {
                    for (i = 0; i < lastNameRegister.Text.Length; i++)
                    {
                        if (!(lastNameRegister.Text[i] >= 65 && lastNameRegister.Text[i] <= 90 || lastNameRegister.Text[i] >= 97 && lastNameRegister.Text[i] <= 122))
                        {
                            MessageBox.Show("Last Name Cannot Have Special Characters.");
                            pass2 = false;
                            break;
                        }
                    }
                }
                if (i == lastNameRegister.Text.Length)
                {
                    string email = emailRegister.Text;
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(email);
                    if (match.Success)
                    {
                        for (i = 0; i < usernameRegister.Text.Length; i++)
                        {
                            if (usernameRegister.Text[i] == ' ')
                            {
                                MessageBox.Show("Username Cannot Contain White Spaces.");
                                pass2 = false;
                                break;
                            }
                        }
                        if (i == usernameRegister.Text.Length)
                        {
                            if (passwordRegister.Text == confirmPasswordRegister.Text)
                            {
                                
                            }
                            else
                            {
                                MessageBox.Show("Passwords Do Not Match.");
                                pass2 = false;
                            }
                        }
                    }
                    else { MessageBox.Show("Please Enter A Valid Email.");
                        pass2 = false;
                    }
                        
                }
            }

            if (!pass2)
            {
                this.Close();
                Registration register = new Registration();
                register.Show();
            }





            if (result1.Count > 0)
            {
                MessageBox.Show("A user with the same email or username already exists...");
                this.Close();
                Registration register = new Registration();
                register.Show();
                pass1 = false;
            }
            if (pass1 && pass2)
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
