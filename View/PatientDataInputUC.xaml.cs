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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Group.ViewModel;

namespace Group.View
{
    /// <summary>
    /// Interaction logic for PatientDataInputUC.xaml
    /// </summary>
    public partial class PatientDataInputUC : UserControl
    {
        public List<Patient> DBPatients { get; private set; }
        public PatientDataInputUC()
        {
            DataContext = new PatientDataInputWindowVM();
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ItemList.Items.Clear();
        }

        public void Add()
        {
            using (UserDataContext context = new UserDataContext())
            {
                if (AgeTextBox.Text == null)
                {
                    MessageBox.Show("Enter the Age of patient", "Error");
                }
                var firstName = FirstNameTextBox.Text;
                var lastName = LastNameTextBox.Text;

                int age = int.Parse(AgeTextBox.Text);
                var ward = WardTextBox.Text;
                var medicalPriorites = SpecialMedicalPrioritiesTextBox.Text;
                //var telephonenb = TeleponeNoTextBox.Text;


                if (firstName != null && age != null)
                {
                    context.Patients.Add(new Patient()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Ward = ward,
                        // PhoneNo = telephonenb,
                        MedicalPriorities = medicalPriorites

                    });
                    context.SaveChanges();
                }

                DBPatients = context.Patients.ToList();
                ItemList.ItemsSource = DBPatients;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Add();
        }

        public void Delete()
        {
            using (UserDataContext context = new UserDataContext())
            {
                Patient selectedPatient = ItemList.SelectedItem as Patient;
                if (selectedPatient != null)
                {
                    Patient patient = context.Patients.Single(x => x.Pid == selectedPatient.Pid);
                    context.Remove(patient);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Select a patient", "Error");
                }

                DBPatients = context.Patients.ToList();
                ItemList.ItemsSource = DBPatients;
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        public void Edit()
        {

        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Edit();
        }

        private void WardTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
