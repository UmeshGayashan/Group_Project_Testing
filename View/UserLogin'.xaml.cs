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
using System.Windows.Shapes;

namespace Group.View
{
    /// <summary>
    /// Interaction logic for UserLogin_.xaml
    /// </summary>
    public partial class UserLogin_ : Window
    {
        public UserLogin_()
        {
            InitializeComponent();
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var Name = txtUser.Text;
            var Password = txtPassword.Password;
            

            using(UserDataContext Dcontext = new UserDataContext())
            {
                bool CorrectDoctorfound = Dcontext.Users.Any(user=> user.UserName == Name && user.Password == Password && user.Role== "D");
                bool CorrectITAdminfound = Dcontext.Users.Any(user => user.UserName == Name && user.Password == Password && user.Role == "I");
                if(CorrectITAdminfound || CorrectDoctorfound)
                {
                    if (CorrectDoctorfound)
                    {
                        CorrectDoctor();
                        Close();
                    }

                    if (CorrectITAdminfound)
                    {
                        CorrectITAdmin();
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Not a Correct User","Warning!");
                }
            }
        }

        public void CorrectDoctor()
        {
            MainView mainView = new MainView();
            mainView.Show();
        }
        public void CorrectITAdmin()
        {
            ITAdiminWindow adiminWindow = new ITAdiminWindow();
            adiminWindow.Show();
        }

        private void TextBlock_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MessageBox.Show("Contact IT Admin", "Error");
        }
    }
}
