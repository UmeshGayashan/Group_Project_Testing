using CommunityToolkit.Mvvm.Input;
using Group.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Group.Model;

namespace Group.ViewModel
{
    public partial class PatientDataInputWindowVM : ViewModelBase
    {
        public List<Patient> DBPatients { get; private set; }

        private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
		}

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; OnPropertyChanged(nameof(Age)); }
		}

		private string ward;

		public string Ward
		{
			get { return ward; }
			set { ward = value; OnPropertyChanged(nameof(Ward)); }
		}

		private string medicalPriorites;

		public string SpecialMedicalPriorities
        {
			get { return medicalPriorites; }
			set { medicalPriorites = value; OnPropertyChanged(nameof(SpecialMedicalPriorities)); }
		}

        public RelayCommand AddCommand { get; }
        public RelayCommand DeleteCommand { get; }
        public Patient SelectedPatient { get; private set; }

        public PatientDataInputWindowVM()
        {
            AddCommand = new RelayCommand(Add, CanAdd);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            
        }

        
        public void Add()
        {
            using (UserDataContext context = new UserDataContext())
            {
                if (Age == null)
                {
                    MessageBox.Show("Enter the Age of patient", "Error");
                }
                context.Patients.Add(new Patient()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Age= Age,
                    Ward= Ward,
                    MedicalPriorities = medicalPriorites
                });
                context.SaveChanges();

                DBPatients = context.Patients.ToList();                
            }
        }

        private bool CanAdd()
        {
            return !string.IsNullOrEmpty(FirstName) && Age != null;
        }


        
        public void Delete()
        {
            using (UserDataContext context = new UserDataContext())
            {
                Patient selectedPatient = SelectedPatient;
                if (selectedPatient != null)
                {
                    context.Remove(selectedPatient);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Select a patient", "Error");
                }

                DBPatients = context.Patients.ToList();
            }
        }
        public bool CanDelete()
        {
            return SelectedPatient != null;
        }

        [RelayCommand]
        public void Edit()
        {

        }
        
    }
}
