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
    /// Interaction logic for Visit.xaml
    /// </summary>
    public partial class Visit : Window
    {
        PrzychodniaEntities DataBase = new PrzychodniaEntities();
        public Visit()
        {
            InitializeComponent();
            VisitTable.ItemsSource = DataBase.Wizyta.ToList();
        }

        private void Button_ClickMainwindownfromVisit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void Button_AddAdress(object sender, RoutedEventArgs e)
        {
            Wizyta visi = new Wizyta()
            {
                data_wizyty = Convert.ToDateTime(DataPickerVisit.Text),
                godzina = TimeSpan.Parse(BoxTime.Text),
                Id_lekarza = Convert.ToInt32(BoxId1.Text),
                Id_pacjenta = Convert.ToInt32(BoxId2)
                
        
            };
            DataBase.Wizyta.Add(visi);
            try
            {
                DataBase.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Wystpąpił błąd. Spróbuj ponownie");
            }
            VisitTable.ItemsSource = DataBase.Wizyta.ToList();
        }

        private void Button_DeleteAdress(object sender, RoutedEventArgs e)
        {

        }
    }
}
