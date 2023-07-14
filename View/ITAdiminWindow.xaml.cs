using Group.Model;
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
    /// Interaction logic for ITAdiminWindow.xaml
    /// </summary>
    public partial class ITAdiminWindow : Window
    {
        public ITAdiminWindow()
        {
            InitializeComponent();
        }

        private void ITDashboard_Click(object sender, RoutedEventArgs e)
        {
            ITframe.Content = new DoctorDataDashboard();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DoctorsData_Click(object sender, RoutedEventArgs e)
        {
            ITframe.Content = new Doctor_sDataInputUC();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            UserLogin_ bckwindow = new UserLogin_();
            bckwindow.Show();
            Close();
        }
    }
}
