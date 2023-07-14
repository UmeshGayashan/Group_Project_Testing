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
using Group.ViewModel;

namespace Group.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            //DataContext = new MainViewVM();
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void pdibtn_Click(object sender, RoutedEventArgs e)
        {
            Nframe.Content = new PatientDataInputUC();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Histroybtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void recordsbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            UserLogin_ bckwindow = new UserLogin_();
            bckwindow.Show();
            Close();
        }

        private void DashBoardBtn_Click(object sender, RoutedEventArgs e)
        {
            Nframe.Content = new PatientsDataDashboardUC();
        }
    }
}
