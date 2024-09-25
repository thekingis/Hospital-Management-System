using Hospital_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hospital_Management_System
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {

        private DatabaseConnection dbConn;
        private string gender, status;
        private RadioButton[] radioButtons;

        public AccountsWindow()
        {
            InitializeComponent();

            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Thread.CurrentThread.CurrentCulture = ci;

            radioButtons = new RadioButton[]{ FemaleG, MaleG, SingleRB, MarriedRB, DivorcedRB, WidowedRB};
            SaveButton.Click += saveButtonClick;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        void saveButtonClick(object sender, RoutedEventArgs e)
        {
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            string dateOfBirth = DateOfBirth.Text;
            string phoneNumber = PhoneNumber.Text;
            string email = Email.Text;
            string address = Address.Text;
            string city = City.Text;
            string state = State.Text;
            string date = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
            bool firstNameIsEmpty = string.IsNullOrEmpty(firstName);
            bool lastNameIsEmpty = string.IsNullOrEmpty(lastName);
            bool dateOfBirthIsEmpty = string.IsNullOrEmpty(dateOfBirth);
            bool phoneNumberIsEmpty = string.IsNullOrEmpty(phoneNumber);
            bool emailIsEmpty = string.IsNullOrEmpty(email);
            bool addressIsEmpty = string.IsNullOrEmpty(address);
            bool cityIsEmpty = string.IsNullOrEmpty(city);
            bool stateIsEmpty = string.IsNullOrEmpty(state);
            bool genderIsNull = gender == null;
            bool statusIsNull = status == null;

            if (firstNameIsEmpty || lastNameIsEmpty || dateOfBirthIsEmpty || phoneNumberIsEmpty || emailIsEmpty || addressIsEmpty || cityIsEmpty || stateIsEmpty || genderIsNull || statusIsNull)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            string queryStr = "INSERT INTO patients VALUES('0', '"+ firstName + "', '"+ lastName + "', '"+ gender + "', '"+ dateOfBirth + "', '"+ phoneNumber + "', '"+ email + "', '"+ status +"', '"+ address + "', '"+ city + "', '" + state + "', '"+ date + "')";
            dbConn = new DatabaseConnection("localhost", "hospital", "root", "");
            int newId = dbConn.insertQuery(queryStr);
            Console.WriteLine(newId);
            Firstname.Clear();
            Lastname.Clear();
            DateOfBirth.Text = "";
            PhoneNumber.Clear();
            Email.Clear();
            Address.Clear();
            City.Clear();
            State.Clear();
            gender = null;
            status = null;
            for(int i = 0; i < radioButtons.Length; i++)
            {
                RadioButton radioButton = radioButtons[i];
                radioButton.IsChecked = false;
            }
            MessageBox.Show("Patient's Data Created");
        }

        private void SelectGender(object sender, RoutedEventArgs e)
        {
            gender = (string)(sender as RadioButton).Content;
        }

        private void SelectStatus(object sender, RoutedEventArgs e)
        {
            status = (string)(sender as RadioButton).Content;
        }

    }
}
