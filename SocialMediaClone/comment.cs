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
    public partial class comment : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        private string postId;

        public comment(string postId)
        {
            this.postId = postId;
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timelineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comment_Load(object sender, EventArgs e)
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
            var collection = database.GetCollection<BsonDocument>("comments");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("post_id", postId);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            commentItem[] postItems = new commentItem[result.Count];
            foreach (var post in result)
            {
                postItems[i] = new commentItem();
                postItems[i].commentId = post[0].ToString();
                postItems[i].userId = post[1].ToString();
                postItems[i].commentDescription = post[2].ToString();
                postItems[i].commentDate = post[3].ToString();
                postItems[i].commentTime = post[4].ToString();
                postItems[i].commentFullname = post[5].ToString();
                postItems[i].postId = post[6].ToString();
                postItems[i].Margin = new Padding(14, 14, 14, 14);
                flowLayoutPanel1.Controls.Add(postItems[i]);
                i++;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
