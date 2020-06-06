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
    public partial class Feedback : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Feedback()
        {
            InitializeComponent();
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("feedback");
            var comment = new BsonDocument
            {
                {"userId", User.id },
                {"submitted_by", User.firstName+" "+User.lastName },
                {"date_submitted", DateTime.Today.ToString("dd/MM/yyyy") },
                {"time_submitted", DateTime.Now.ToString("HH:mm:ss tt") },
                {"username", User.username},
                {"description",feedbackAdd.Text },
            };
            collection.InsertOne(comment);
            MessageBox.Show("Your feedback or query has been submitted...");
            Feedback feedback = new Feedback();
            this.Hide();
            feedback.Show();
        }

        private void Feedback_Load(object sender, EventArgs e)
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
        }
    }
}
