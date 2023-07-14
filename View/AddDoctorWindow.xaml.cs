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
    /// Interaction logic for AddDoctorWindow.xaml
    /// </summary>
    public partial class AddDoctorWindow : Window
    {
        public AddDoctorWindow(AddDoctorWindowVM newVM)
        {
            InitializeComponent();
            DataContext = newVM;
            newVM.CloseAction = () => Close();
        }

        //public object Dctor { get; internal set; }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
