using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace D7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Autentication.LoadUsers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text;
            string password = PasswordInput.Password;
            AutenticationPopUp autenticationPopUp;

            if (Autentication.AutenticateUser(name, password))
            {
                CurrentUser.UserName = name;
                CurrentUser.LoginStatus = "autenticaded";

                autenticationPopUp = new AutenticationPopUp();
                autenticationPopUp.Show();
                this.Close();
            } else
            {
                autenticationPopUp = new AutenticationPopUp();
                autenticationPopUp.Show();
            }
        }
    }
}