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
    public partial class AddFaq : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public AddFaq()
        {
            InitializeComponent();
        }

        private void AddFaq_Load(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("faqs");
            var question = new BsonDocument
            {
                {"question", questionAdd.Text },
                {"answer",answerAdd.Text },
                
            };
            collection.InsertOne(question);
            MessageBox.Show("Question Added To FAQs..");
            this.Hide();
            AddFaq faq = new AddFaq();
            faq.Show();
        }
    }
}
