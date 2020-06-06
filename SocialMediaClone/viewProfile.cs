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
    public partial class viewProfile : Form
    {
        private string userId;
        private int totalLikes = 0;
        private int totalPosts;
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public viewProfile(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void viewProfile_Load(object sender, EventArgs e)
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


            var i = 0;
            var collection1 = database.GetCollection<BsonDocument>("posts");
            var builder1 = Builders<BsonDocument>.Filter;
            var filter1 = builder1.Eq("userId", userId);
            var result1 = collection1.Find(filter1).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            PostItem[] postItems = new PostItem[result1.Count];
            foreach (var post in result1)
            {
                postItems[i] = new PostItem();
                postItems[i].postId = post[0].ToString();
                postItems[i].postDescription = post[3].ToString();
                postItems[i].postDate = post[4].ToString();
                postItems[i].postTime = post[5].ToString();
                postItems[i].postFullname = post[6].ToString();
                postItems[i].postLikes = post[7].ToString();
                totalLikes = totalLikes + post[7].ToInt32();
                postItems[i].Margin = new Padding(14, 14, 14, 14);
                flowLayoutPanel1.Controls.Add(postItems[i]);
                i++;
                totalPosts++;
            }
            




            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(userId));
            var result2 = collection.Find(filter).ToList();
            foreach(var user in result2)
            {
                fullnameLabel.Text = user[1].ToString() + " " + user[2].ToString();
                dobLabel.Text = user[4].ToString();
                genderLabel.Text = user[3].ToString();
                relationLabel.Text = user[11].ToString();
                contactLabel.Text = user[10].ToString();
                postsLabel.Text = totalPosts.ToString();
                reputationLabel.Text = (totalLikes * 5).ToString();
            }



        }
    }
}
