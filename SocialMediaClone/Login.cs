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
    public partial class Login : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Connectivity Error...Please Check Your Internet...");
                throw;
            }
            User.friends.Clear();                   //
            User.friends2.Clear();
        }

        private void loginConfirmButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("email", emailLogin.Text), builder.Eq("password", passwordLogin.Text));
            var result = collection.Find(filter).ToList();
            if (result.Count > 0)
            {
                var user1 = result[0];

                User.id = user1[0].ToString();
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
                User.isAdmin = false;

                var arrayOfStrings = user1["friends"].AsBsonArray.Select(p => p.AsString).ToArray();

                foreach (string friend in arrayOfStrings)
                {
                    User.friends.Add(friend);
                }
                var builder2 = Builders<BsonDocument>.Filter.Empty;
                var result2 = collection.Find(builder2).ToList();
                foreach (string friend in User.friends)
                {
                    foreach (var res in result2)
                    {
                        if (res[0].ToString() == friend)
                        {
                            var arrayOfFriends2 = res["friends"].AsBsonArray.Select(p => p.AsString).ToArray();
                            foreach (string mem in arrayOfFriends2)
                            {
                                if (mem == User.id)
                                {
                                    User.friends2.Add(res[0].ToString());
                                }
                            }
                        }



                    }
                }
                //MessageBox.Show(User.friends2.Count.ToString());

                var collection3 = database.GetCollection<BsonDocument>("adm");
                var builder3 = Builders<BsonDocument>.Filter.Empty;
                var result3 = collection3.Find(builder3).ToList();

                foreach (var res in result3)
                {

                    if (User.username == res[1].ToString())
                    {
                        User.isAdmin = true;

                    }
                }

                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
                //MessageBox.Show(User.friends2.Count.ToString());

            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }

            

        }

        private void gotoRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration register = new Registration();
            register.ShowDialog();
        }
    }
}
