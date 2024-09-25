using Hospital_Management_System.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private int id;
        private string text;
        private DatabaseConnection dbConn;
        private List<Window> windows;

        public LoginWindow(int id, string text)
        {
            InitializeComponent();

            this.id = id;
            this.text = text;
            HeadText.Text = text + " Login";
            windows = new List<Window>();
            windows.Add(new SuperAdminWindow());
            windows.Add(new AdminWindow());
            windows.Add(new AccountsWindow());
            windows.Add(new AccountsWindow());
            windows.Add(new AccountsWindow());
            windows.Add(new AccountsWindow());
            windows.Add(new AccountsWindow());
            windows.Add(new AccountsWindow());

            BackButton.Foreground = new SolidColorBrush(Colour.skyBlue);
            LoginButton.Background = new SolidColorBrush(Colour.skyBlue);

            BackButton.Click += backButtonClick;
            LoginButton.Click += loginButtonClick;

            Username.Focus();
            Username.KeyDown += new KeyEventHandler(tb_keyDown);
            Password.KeyDown += new KeyEventHandler(tb_keyDown);

        }

        void tb_keyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                loginButtonClick(null, null);
            }
        }

        void loginButtonClick(object sender, RoutedEventArgs e)
        {
            string username = Functions.ReplaceWhitespace(Username.Text, "").ToLower();
            string password = Functions.ReplaceWhitespace(Password.Password.ToString(), "");
            bool usernameIsEmpty = string.IsNullOrEmpty(username);
            bool passwordIsEmpty = string.IsNullOrEmpty(password);

            if(usernameIsEmpty || passwordIsEmpty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            string queryStr = "SELECT * FROM accounts WHERE deptId = " + id + " AND username = '" + username + "' AND password = '" + password + "'";
            dbConn = new DatabaseConnection("localhost", "hospital", "root", "");
            MySqlDataReader reader = dbConn.executeQuery(queryStr);

            if (!reader.HasRows)
            {
                MessageBox.Show("No login match found for " + text + " Department");
                return;
            }

            reader.Read();
            int userId = Convert.ToInt32(reader[0].ToString());
            int deptId = Convert.ToInt32(reader[1].ToString());
            string name = reader[2].ToString();
            Functions.LoginUser(userId, deptId, name);
            Window window = windows[deptId - 1];
            this.Close();
            window.Show();

        }

        void backButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
