using System.Windows;

namespace Hospital_Management_System.Utils
{
    class Functions
    {

        public static string ReplaceWhitespace(string s, string replacement)
        {
            return Constants.sWhitespace.Replace(s, replacement);
        }

        public static void LoginUser(int userId, int deptId, string name)
        {
            Application.Current.Properties["name"] = name;
            Application.Current.Properties["userId"] = userId;
            Application.Current.Properties["deptId"] = deptId;
        }

        public static void LogoutUser()
        {
            Application.Current.Properties.Remove("name");
            Application.Current.Properties.Remove("userId");
            Application.Current.Properties.Remove("deptId");
        }

    }
}
