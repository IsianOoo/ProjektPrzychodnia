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

namespace ProjektPrzychodnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_PatientClick(object sender, RoutedEventArgs e)
        {
            Patient Pt = new Patient();
            Pt.Show();
        }

        private void Button_DoctorClick(object sender, RoutedEventArgs e)
        {
            Doctor Dc = new Doctor();
            Dc.Show();
        }

        private void Button_VisitClick(object sender, RoutedEventArgs e)
        {
            Visit Vs = new Visit();
            Vs.Show();
        }

        private void Button_AdressClick(object sender, RoutedEventArgs e)
        {
            Adress Ad = new Adress();
            Ad.Show();
        }
    }
}
