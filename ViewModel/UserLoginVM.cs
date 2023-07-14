using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Group.ViewModel
{
    public partial class UserLoginVM
    {
        [RelayCommand]
        public void reset()
        {
            MessageBox.Show("Contact IT Admin","Error");
        }
        public UserLoginVM()
        {
            
        }
    }
}
