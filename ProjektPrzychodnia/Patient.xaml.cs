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
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ProjektPrzychodnia.masterDataSet masterDataSet = ((ProjektPrzychodnia.masterDataSet)(this.FindResource("masterDataSet")));
            // Load data into the table Pacjent. You can modify this code as needed.
            ProjektPrzychodnia.masterDataSetTableAdapters.PacjentTableAdapter masterDataSetPacjentTableAdapter = new ProjektPrzychodnia.masterDataSetTableAdapters.PacjentTableAdapter();
            masterDataSetPacjentTableAdapter.Fill(masterDataSet.Pacjent);
            System.Windows.Data.CollectionViewSource pacjentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("pacjentViewSource")));
            pacjentViewSource.View.MoveCurrentToFirst();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
