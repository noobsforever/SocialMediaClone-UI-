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
using System.Collections.ObjectModel;
using MongoDB.Driver;
namespace SocialMediaClone
{
    public partial class SearchItem : UserControl
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";

        #region properties
        private string full_name;
        private string user_id;
        private bool is_friend;
        [Category("Custom Props")]
        public string fullName
        {
            get { return full_name; }
            set { full_name = value; fullnameLabel.Text = value; }
        }

        public string userId
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public bool isFriend
        {
            get { return is_friend; }
            set { is_friend = value; }
        }


        #endregion
        public SearchItem()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchItem_Load(object sender, EventArgs e)
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
            bool isFollowing = false;
            bool isFollowedBack = false;
            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(User.id));
            var result = collection.Find(filter).ToList();

            var filter2 = builder.Eq("_id", ObjectId.Parse(userId));
            var result2 = collection.Find(filter2).ToList();

            var friendList = result[0]["friends"].AsBsonArray.Select(p => p.AsString).ToArray();
            var friendList2 = result2[0]["friends"].AsBsonArray.Select(p => p.AsString).ToArray();

            foreach (var friend in friendList)
            {
                if (friend == userId)
                {
                    isFollowing = true;
                }
            }

            foreach (var friend in friendList2)
            {
                if (friend == User.id)
                {
                    isFollowedBack = true;
                }
            }
            if (isFollowedBack && isFollowing)
            {
                isFriend = true;
            }


            if (isFriend)
            {
                followButton.Text = "Friends";
                viewProfileButton.Visible = true;
            }
            else if (!isFriend && isFollowing)
            {
                followButton.Text = "Friend Request Sent";
                viewProfileButton.Visible = false;
            }
            else if (!isFollowing && isFollowedBack)
            {
                followButton.Text = "Accept Friend Request";
                viewProfileButton.Visible = false;
            }
            else
            {
                followButton.Text = "Add Friend";
                viewProfileButton.Visible = false;
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void followButton_Click(object sender, EventArgs e)
        {
             var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(User.id));
            var filter2 = builder.Eq("_id", ObjectId.Parse(userId));
            var result2 = collection.Find(filter2).ToList();
            var friendList2 = result2[0]["friends"].AsBsonArray.Select(p => p.AsString).ToArray();


            if (followButton.Text == "Add Friend" || followButton.Text == "Accept Friend Request")
            {
                var update = Builders<BsonDocument>.Update.Push("friends", userId);
                var result = collection.UpdateOne(filter, update);
                User.friends.Add(userId);
                foreach (var friend in friendList2)
                {
                    if (friend == User.id)
                    {
                        User.friends2.Add(userId);
                    }
                }
                if (ParentForm.Text == "Notifications")
                {
                    ParentForm.ParentForm.Hide();
                    ParentForm.Hide();
                    Menu menu = new Menu();
                    menu.OpenChildForm(new Notifications());
                    menu.Show();
                }

                else
                {
                    SearchResult Srchresult = new SearchResult(result2[0][7].ToString());
                    ParentForm.Hide();
                    Srchresult.Show();
                    ParentForm.Update();
                }
            }
            else if (followButton.Text == "Friend Request Sent")        
            {
                var update = Builders<BsonDocument>.Update.Pull("friends", userId);
                var result = collection.UpdateOne(filter, update);
                SearchResult Srchresult = new SearchResult(result2[0][7].ToString());
                this.Hide();
                User.friends.Remove(userId);
                ParentForm.Hide();
                Srchresult.Show();
                
            }
            else
            {
                var update = Builders<BsonDocument>.Update.Pull("friends", userId);
                var result = collection.UpdateOne(filter, update);
                User.friends.Remove(userId);
                var update2 = Builders<BsonDocument>.Update.Pull("friends", User.id);
                User.friends2.Remove(userId);
                var result3 = collection.UpdateOne(filter2, update2);
                if (ParentForm.Text == "Friends")
                {
                    
                    ParentForm.ParentForm.Hide();
                    ParentForm.Hide();
                    Menu menu = new Menu();
                    menu.OpenChildForm(new Friends());
                    menu.Show();
                }
                else
                {
                    SearchResult Srchresult = new SearchResult(result2[0][7].ToString());
                    this.Hide();
                    ParentForm.Hide();
                    Srchresult.Show();

                }

            }
        }
        }
    }
