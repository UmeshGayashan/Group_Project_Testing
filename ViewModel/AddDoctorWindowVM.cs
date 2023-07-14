using CommunityToolkit.Mvvm.ComponentModel;
using Group.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group.ViewModel
{
    public partial class AddDoctorWindowVM :ObservableObject
    {
        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string role;

        [ObservableProperty]
        public int telephone;

        [ObservableProperty]
        public string ward;

        [ObservableProperty]
        public string clinicTime;

        public Doctor Dctor { get; private set; }
        public Action CloseAction { get; internal set; }

        public AddDoctorWindowVM(Doctor Dctor)
        {
            
        }

        public AddDoctorWindowVM()
        {
            
        }
    }
}
