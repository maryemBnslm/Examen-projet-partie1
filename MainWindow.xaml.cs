using System;
using System.Collections.Generic;
using System.Windows;

namespace Examen_projet_partie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>();

        }

      public class User
        {
            public int Num { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Age { get; set; }
            public string Sexe { get; set; }
            public string Programme { get; set; }




        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
