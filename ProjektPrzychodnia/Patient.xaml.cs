using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektPrzychodnia
{
    /// <summary>
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        PrzychodniaEntities DataBase = new PrzychodniaEntities();
       


        public Patient()
        {
            InitializeComponent();
            PatientTable.ItemsSource = DataBase.Pacjent.ToList();
        }

        

        private void Button_AddPatient(object sender, RoutedEventArgs e)
        {
            string pesel = TextBoXPesel.Text;
            Regex regexpesel = new Regex(@"^\d{11}$");
            Match matchpesel = regexpesel.Match(pesel);
            if(!matchpesel.Success || TextBoXPesel.Text.Length > 11 || TextBoXPesel.Text.Length < 11)
            {
                MessageBox.Show("Błędny pesel");
                return;
            }
            Pacjent patient = new Pacjent()
            {
                Imie = TextBoxFirstName.Text,
                nazwisko = TextBoxSumName.Text,
                Pesel = TextBoXPesel.Text
            };
            DataBase.Pacjent.Add(patient);
            try
            {
               DataBase.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Wystpąpił błąd. Spróbuj ponownie");
            }
            
            PatientTable.ItemsSource = DataBase.Pacjent.ToList();
        }

        private void Button_DeletePatient(object sender, RoutedEventArgs e)
        {
            if(PatientTable.SelectedValue   != null)
            {
                var pacjent = DataBase.Pacjent.FirstOrDefault(p => p.Id_pacjenta == ((Pacjent)PatientTable.SelectedValue).Id_pacjenta);
                DataBase.Pacjent.Remove(pacjent);
                DataBase.SaveChanges();
                PatientTable.ItemsSource = DataBase.Pacjent.ToList();
            }
        }

        private void Button_ClickMainwindownFromPatient(object sender, RoutedEventArgs e)
        {
            
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
