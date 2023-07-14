using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class PatientDataInputVM:ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string ward;

        [ObservableProperty]
        public string medicalpriorities;

        [ObservableProperty]
        ObservableCollection<Patient> patients;

        //public Patient Ptnt { get;private set; }

        public PatientDataInputVM()
        {
            
            patients = new ObservableCollection<Patient>();
            LoadData();
        }

        [ObservableProperty]
        public Patient selectedPatient = null;

        [RelayCommand]
        public void Add()
        {
            Patient ptnt = new Patient()
            {
                FirstName = Firstname,
                LastName = Lastname,
                Age = Age,
                Ward = Ward,
                MedicalPriorities = Medicalpriorities,
            };
            patients.Add(ptnt);

            using (var db = new UserDataContext())
            {
                db.Patients.Add(ptnt);
                db.SaveChanges();
            }
            LoadData();
        }

        [RelayCommand]
        public void LoadData()
        {
            using (var db = new UserDataContext())
            {
                var list = db.Patients.OrderBy(p => p.Pid).ToList();
                patients.Clear();
                foreach (var patient in list)
                {
                    patients.Add(patient);
                }
            }
        }

    }
}
