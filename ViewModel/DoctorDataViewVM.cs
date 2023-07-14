using CommunityToolkit.Mvvm.ComponentModel;
using Group.Model;
using Group.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group.ViewModel
{
    public partial class DoctorDataViewVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Doctor> doctors;

        [ObservableProperty]
        public Doctor selectedDoctor = null;

        public void Message()
        {
            MessageBox.Show($"{selectedDoctor.UserName} use another Password", "Error");
        }

        public void AddDoctor()
        {
            var newVM = new AddDoctorWindowVM();
            AddDoctorWindow newWindow = new AddDoctorWindow(newVM);
            newWindow.ShowDialog();
            if (newVM.Dctor.FirstName != null)
            {
                doctors.Add(newVM.Dctor);
            }
        }
        public void DeleteDoctor()
        {
            if (selectedDoctor != null)
            {
                MessageBox.Show($"{selectedDoctor.UserName} is Deleted successfuly.", "DELETED \a ");
                doctors.Remove(selectedDoctor);
            }
            else
            {
                MessageBox.Show("Please select the doctor before delete.", "Error");
            }
        }

        public void EditDoctor()
        {

        }
    }
    
}
