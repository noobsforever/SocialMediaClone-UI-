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
    public partial class Newsfeed : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Newsfeed()
        {
            InitializeComponent();
            
        }

        private void Newsfeed_Load(object sender, EventArgs e)
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

            var resultCount = 0;
            var i = 0;
            var collection = database.GetCollection<BsonDocument>("posts");
            var builder = Builders<BsonDocument>.Filter.Empty;
            var result = collection.Find(builder).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            foreach (var post in result)
            {
                foreach (var friend in User.friends2)
                {
                    if (post[1].ToString() == friend)
                    {
                        resultCount++;
                    }
                }


                if (post[1].ToString() == User.id)
                {
                    resultCount++;
                }

            }
            PostItem[] postItems = new PostItem[resultCount];
            foreach (var post in result)
            {
                foreach (var friend in User.friends2)
                {
                    if (post[1].ToString() == friend)
                    {
                        postItems[i] = new PostItem();
                        postItems[i].postId = post[0].ToString();
                        postItems[i].postDescription = post[3].ToString();
                        postItems[i].postDate = post[4].ToString();
                        postItems[i].postTime = post[5].ToString();
                        postItems[i].postFullname = post[6].ToString();
                        postItems[i].postLikes = post[7].ToString();
                        postItems[i].Dock = DockStyle.Top;
                        postItems[i].Margin = new Padding(14, 14, 14, 14);
                        flowLayoutPanel1.Controls.Add(postItems[i]);
                        i++;
                    }
                }


                if (post[1].ToString() == User.id)
                {
                    postItems[i] = new PostItem();
                    postItems[i].postId = post[0].ToString();
                    postItems[i].postDescription = post[3].ToString();
                    postItems[i].postDate = post[4].ToString();
                    postItems[i].postTime = post[5].ToString();
                    postItems[i].postFullname = post[6].ToString();
                    postItems[i].postLikes = post[7].ToString();
                    postItems[i].Dock = DockStyle.Top;
                    postItems[i].Margin = new Padding(14, 14, 14, 14);
                    flowLayoutPanel1.Controls.Add(postItems[i]);
                    i++;
                }

            }

        }
    }
}
