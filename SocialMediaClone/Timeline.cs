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
    public partial class Timeline : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Timeline()
        {
            InitializeComponent();
        }

        private void postItem1_Load(object sender, EventArgs e)
        {

        }

        private void Timeline_Load(object sender, EventArgs e)
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
            var collection = database.GetCollection<BsonDocument>("posts");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("userId", User.id);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            PostItem[] postItems = new PostItem[result.Count];
            foreach (var post in result)
            {
                postItems[i] = new PostItem();
                postItems[i].postId = post[0].ToString();
                postItems[i].postDescription = post[3].ToString();
                postItems[i].postDate = post[4].ToString();
                postItems[i].postTime = post[5].ToString();
                postItems[i].postFullname = post[6].ToString();
                postItems[i].postLikes = post[7].ToString();
                postItems[i].Margin = new Padding(14, 14, 14, 14);
                flowLayoutPanel1.Controls.Add(postItems[i]);
                i++;
                emptyLabel.Text = "";
            }
            if (i == 0)
            {
                emptyLabel.Text = "Your Timeline is empty..";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("posts");
            var post = new BsonDocument
            {
                {"userId", User.id },
                {"title", "empty" },
                {"description", descriptionText.Text },
                {"date_created", DateTime.Today.ToString("dd/MM/yyyy") },
                {"time_created", DateTime.Now.ToString("HH:mm:ss tt") },
                {"posted_by", User.firstName+" "+User.lastName },
                {"likes", 0 },
                {"comments",0 },
            };
            collection.InsertOne(post);
            Menu menu = new Menu();
            menu.Show();
            menu.OpenChildForm(new Timeline());
            ParentForm.Hide();
        }
    }
}
