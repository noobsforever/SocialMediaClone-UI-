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
    public partial class Faq : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Faq()
        {
            InitializeComponent();
        }

        private void Faq_Load(object sender, EventArgs e)
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
            var collection = database.GetCollection<BsonDocument>("faqs");
            var builder = Builders<BsonDocument>.Filter.Empty;
            
            var result = collection.Find(builder).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            faqItem[] faqItems = new faqItem[result.Count];
            foreach (var post in result)
            {
                faqItems[i] = new faqItem();
                faqItems[i].Question = post[1].ToString();
                faqItems[i].Answer = post[2].ToString();
                faqItems[i].Margin = new Padding(14, 14, 14, 14);
                flowLayoutPanel1.Controls.Add(faqItems[i]);
                i++;
            }
        }
    }
}
