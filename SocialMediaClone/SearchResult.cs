using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
namespace SocialMediaClone
{
    public partial class SearchResult : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        private string query;
        public SearchResult(string query)
        {
            this.query = query;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchResult_Load(object sender, EventArgs e)
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


            int i = 0;
            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("username", query);
            var result = collection.Find(filter).ToList();
            SearchItem[] item = new SearchItem[result.Count];
            if (result.Count == 0)
            {
                MessageBox.Show("No Such Users found...");
                this.Hide();
                this.Close();
            }
            else
            {
                foreach (var res in result)
                {
                    item[i] = new SearchItem();
                    item[i].fullName = res[1].ToString() + " " + res[2].ToString();
                    item[i].userId = res[0].ToString();
                    item[i].isFriend = false;
                    item[i].Margin = new Padding(14, 14, 14, 14);
                    flowLayoutPanel1.Controls.Add(item[i]);
                }
            }
        }
    }
}
