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
using MongoDB.Driver;
namespace SocialMediaClone
{
    public partial class commentItem : UserControl
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";

        #region properties
        private string comment_description;
        private string comment_fullname;
        private string post_id;
        private string comment_date;
        private string comment_time;
        private string comment_id;
        private string user_id;
        [Category("Custom Props")]
        public string commentDescription
        {
            get { return comment_description; }
            set { comment_description = value; descriptionLabel.Text = value; }
        }

        public string userId
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public string commentFullname
        {
            get { return comment_fullname; }
            set { comment_fullname = value; fullnameLabel.Text = value; }
        }



        public string commentDate
        {
            get { return comment_date; }
            set { comment_date = value; dateLabel.Text = value; }
        }

        public string commentTime
        {
            get { return comment_time; }
            set { comment_time = value; timeLabel.Text = value; }
        }

        public string postId
        {
            get { return post_id; }
            set { post_id = value; }
        }

        public string commentId
        {
            get { return comment_id; }
            set { comment_id = value; }
        }
        #endregion
        public commentItem()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("comments");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(commentId));
            var result = collection.DeleteOne(filter);
            ParentForm.Hide();
            comment com = new comment(postId);
            com.Show();
        }

        private void commentItem_Load(object sender, EventArgs e)
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
            
            var collection3 = database.GetCollection<BsonDocument>("comments");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("_id", ObjectId.Parse(comment_id));
            var result3 = collection3.Find(filter3).ToList();
            foreach (var res in result3)
            {
                if (res[1].ToString() == User.id)
                {
                    deleteButton.Visible = true;
                }
                else
                {
                    deleteButton.Visible = false;
                }
            }
        }

        private void descriptionLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
