﻿using System;
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

        }

        private void Button_DeleteAdress(object sender, RoutedEventArgs e)
        {

        }
    }
}
