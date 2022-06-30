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

namespace ProjektPrzychodnia
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        PrzychodniaEntities DataBase = new PrzychodniaEntities();
        private string nazwisko;
        private string Imie;

        public Doctor()
        {
            InitializeComponent();
            DoctorTable.ItemsSource = DataBase.Lekarz.ToList();
        }

        

        private void Button_AddDoctor(object sender, RoutedEventArgs e)
        {
            Lekarz doktor = new Lekarz()
            {
                Imie = TextBoxFirstNameDoctor.Text,
                nazwisko = TextBoxSumNameDoctor.Text
            };
            DataBase.Lekarz.Add(doktor);
            DataBase.SaveChanges();
            DoctorTable.ItemsSource = DataBase.Lekarz.ToList();
        }

        private void Button_DeleteDoctor(object sender, RoutedEventArgs e)
        {
            if(DoctorTable.SelectedValue != null)
            {
                var doktor = DataBase.Lekarz.FirstOrDefault(p => p.Id_lekarza == ((Lekarz)DoctorTable.SelectedValue).Id_lekarza);
            }
        }

        private void Button_ClickMainwindown(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
