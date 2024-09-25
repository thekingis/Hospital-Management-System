using Hospital_Management_System.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DatabaseConnection dbConn;

        public MainWindow()
        {
            InitializeComponent();

            dbConn = new DatabaseConnection("localhost", "hospital", "root", "");
            MySqlDataReader reader = dbConn.executeQuery("SELECT * FROM departments");
            List<Department> dataList = new List<Department>();
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string text = (string)reader["text"];
                Department department = new Department(id, text);
                dataList.Add(department);
            }
            int numRows = dataList.Count();
            double rowCount = Math.Ceiling((double)numRows / 2);

            for (int i = 0; i < rowCount; i++)
            {
                DeptGrid.RowDefinitions.Add(new RowDefinition());
            }

            var style = new Style
            {
                TargetType = typeof(Border),
                Setters = { new Setter { Property = Border.CornerRadiusProperty, Value = new CornerRadius(5) } }
            };

            for (int x = 0; x < numRows; x++)
            {
                GridPosition gridPosition = new GridPosition(x, 4);
                Department department = dataList[x];
                Button button = new Button();
                button.Tag = department.id;
                button.Content = department.text;
                button.Cursor = Cursors.Hand;
                button.Background = new SolidColorBrush(Colour.skyBlue);
                button.Foreground = new SolidColorBrush(Colour.white);
                button.Resources.Add(style.TargetType, style);
                button.Margin = new Thickness(4);
                button.FontSize = 20;
                button.Click += buttonClick;
                button.MouseEnter += buttonMouseEnter;
                button.MouseLeave += buttonMouseLeave;
                button.Height = 200;

                Grid.SetColumn(button, gridPosition.x);
                Grid.SetRow(button, gridPosition.y);

                DeptGrid.Children.Add(button);
            }

        }

        void buttonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int id = Convert.ToInt32(button.Tag);
            string text = button.Content.ToString();
            LoginWindow loginWindow = new LoginWindow(id, text);
            this.Close();
            loginWindow.Show();
        }

        void buttonMouseEnter(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Colour.skyBlueFade);
            button.Foreground = new SolidColorBrush(Colour.black);
        }

        void buttonMouseLeave(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Colour.skyBlue);
            button.Foreground = new SolidColorBrush(Colour.white);
        }
    }
}
