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
    public partial class Friends : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "socialmediaproject";
        public Friends()
        {
            InitializeComponent();
           
        }

        private void Friends_Load(object sender, EventArgs e)
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

            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter.Empty;
            var result = collection.Find(builder).ToList();
            SearchItem[] item = new SearchItem[result.Count];
            int i = 0;
            foreach (var res in result)
            {
                var friendList = res["friends"].AsBsonArray.Select(p => p.AsString).ToArray();
                foreach (var friend in friendList)      //looping through user's friend list
                {

                    if (friend == User.id)      //if their friendlist has a mention of other
                    {

                        foreach (var id in User.friends)            //looping through current user's friendlist
                        {

                            if (id == res[0].ToString())        //if match found
                            {
                                item[i] = new SearchItem();
                                item[i].fullName = res[1].ToString() + " " + res[2].ToString();
                                item[i].userId = res[0].ToString();
                                item[i].isFriend = false;
                                item[i].Margin = new Padding(14, 14, 14, 14);
                                flowLayoutPanel1.Controls.Add(item[i]);
                                i++;
                                emptyLabel.Text = "";
                            }

                        }

                    }
                }
            }
            if (i == 0)
            {
                emptyLabel.Text = "You Have no Friends....";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
