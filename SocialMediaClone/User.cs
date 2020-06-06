using System.Collections.Generic;

namespace SocialMediaClone
{
    public static class User
    {
        public static string id { get; set; }
        public static string email { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string gender { get; set; }
        public static string dob { get; set; }
        public static string password { get; set; }
        public static string username { get; set; }
        public static string relation { get; set; }

        public static string phone { get; set; }
        public static int reputation { get; set; }

        public static IList<string> friends = new List<string>();

        public static IList<string> friends2 = new List<string>();

        public static bool isAdmin;

    }
}