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
using System.Collections.ObjectModel;
namespace SocialMediaClone

{
    public partial class PostItem : UserControl
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";

        #region properties
        private string post_description;
        private string post_fullname;
        private string post_likes;
        private string post_id;
        private string post_date;
        private string post_time;

        [Category("Custom Props")]
        public string postDescription
        {
            get { return post_description; }
            set { post_description = value; descriptionLabel.Text = value; }
        }
        public string postFullname
        {
            get { return post_fullname; }
            set { post_fullname = value; fullnameLabel.Text = value; }
        }

        public string postLikes
        {
            get { return post_likes; }
            set { post_likes = value; likeLabel.Text = value; }
        }



        public string postDate
        {
            get { return post_date; }
            set { post_date = value; dateLabel.Text = value; }
        }

        public string postTime
        {
            get { return post_time; }
            set { post_time = value; timeLabel.Text = value; }
        }

        public string postId
        {
            get { return post_id; }
            set { post_id = value; }
        }




        #endregion
        public PostItem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            
            comment com = new comment(postId);
            com.Show();
        }

        private void PostItem_Load(object sender, EventArgs e)
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
            

            var collection3 = database.GetCollection<BsonDocument>("posts");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("_id", ObjectId.Parse(postId));
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

            var collection = database.GetCollection<BsonDocument>("comments");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("post_id", postId);
            var result2 = collection.Find(filter).ToList();
            commentLabel.Text = result2.Count.ToString();

            var collection1 = database.GetCollection<BsonDocument>("users");
            var filter2 = builder.Eq("_id", ObjectId.Parse(User.id));
            var result = collection1.Find(filter2).ToList();
            var likeList = result[0]["liked"].AsBsonArray.Select(p => p.AsString).ToArray();
            var disLikeList = result[0]["disliked"].AsBsonArray.Select(p => p.AsString).ToArray();
            foreach (var liked in likeList)
            {
                if (liked == postId)
                {
                    likeButton.Visible = false;
                }
            }
            foreach (var disliked in disLikeList)
            {
                if (disliked == postId)
                {
                    dislikeButton.Visible = false;
                }
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            bool dislikedFlag = false;
            var likes = Convert.ToInt32(likeLabel.Text);
            var collection1 = database.GetCollection<BsonDocument>("users");
            var builder2 = Builders<BsonDocument>.Filter;
            var filter3 = builder2.Eq("_id", ObjectId.Parse(User.id));
            var result3 = collection1.Find(filter3).ToList();
            var likeList = result3[0]["liked"].AsBsonArray.Select(p => p.AsString).ToArray();
            var disLikeList = result3[0]["disliked"].AsBsonArray.Select(p => p.AsString).ToArray();
            foreach (var disliked in disLikeList)
            {
                if (disliked == postId)
                {
                    
                    dislikedFlag = true;
                }
            }
            if (dislikedFlag)
            {
                likes+=2;
            }
            else
            {
                likes++;
            }
            var collection = database.GetCollection<BsonDocument>("posts");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(postId));
            var update = Builders<BsonDocument>.Update.Set("likes", likes);
            var result = collection.UpdateOne(filter, update);
            var result2 = collection.Find(filter).ToList();
            likeLabel.Text = likes.ToString();
            dislikeButton.Show();
            likeButton.Hide();
            var collection2 = database.GetCollection<BsonDocument>("users");
            var filter2 = builder.Eq("_id", ObjectId.Parse(User.id));
            var updateLike = Builders<BsonDocument>.Update.Push("liked", postId);
            var updateDislike = Builders<BsonDocument>.Update.Pull("disliked", postId);
            var query1 = collection2.UpdateOne(filter2, updateLike);
            var query2 = collection2.UpdateOne(filter2, updateDislike);
        }

        private void likeLabel_Click(object sender, EventArgs e)
        {

        }

        private void dislikeButton_Click(object sender, EventArgs e)
        {

           
            
            bool likedFlag = false;
            var likes = Convert.ToInt32(likeLabel.Text);
            var collection1 = database.GetCollection<BsonDocument>("users");
            var builder2 = Builders<BsonDocument>.Filter;
            var filter3 = builder2.Eq("_id", ObjectId.Parse(User.id));
            var result3 = collection1.Find(filter3).ToList();
            var likeList = result3[0]["liked"].AsBsonArray.Select(p => p.AsString).ToArray();
            var disLikeList = result3[0]["disliked"].AsBsonArray.Select(p => p.AsString).ToArray();
            foreach (var liked in likeList)
            {
                if (liked == postId)
                {
                    likedFlag = true;
                }
            }
            if (likedFlag)
            {
                likes -= 2;
            }
            else
            {
                likes--;
            }
            var collection = database.GetCollection<BsonDocument>("posts");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(postId));
            var update = Builders<BsonDocument>.Update.Set("likes", likes);
            var result = collection.UpdateOne(filter, update);
            var result2 = collection.Find(filter).ToList();
            likeLabel.Text = likes.ToString();
            dislikeButton.Hide();
            likeButton.Show();
            var collection2 = database.GetCollection<BsonDocument>("users");
            var filter2 = builder.Eq("_id", ObjectId.Parse(User.id));
            var updateLike = Builders<BsonDocument>.Update.Pull("liked", postId);
            var updateDislike = Builders<BsonDocument>.Update.Push("disliked", postId);
            var query1 = collection2.UpdateOne(filter2, updateLike);
            var query2 = collection2.UpdateOne(filter2, updateDislike);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("posts");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(postId));
            var result = collection.DeleteOne(filter);
            ParentForm.ParentForm.Hide();
            ParentForm.Hide();
            Menu menu = new Menu();
            menu.OpenChildForm(new Timeline());
            menu.Show();
        }

        private void descriptionLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
