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
using RygOgRejs.Entities;
using RygOgRejs.DataAccess;

namespace RygOgRejs.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private UserControl currentUserControlCentre, currentUserControlRight;
        List<DataGridEnitty> GridEntity;
        public MainWindow()
        {
            InitializeComponent();
            GridEntity = new List<DataGridEnitty>();
        }

        private void OnMenuFilesClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vil du afslutte Ryg & Rejs?", "Luk Ryg & Rejs", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void ButtonJourneys_Click(object sender, RoutedEventArgs e)
        {
            Journey journey = new Journey(Destination.Billund, DateTime.Now, true, 1, 0, 20);
            currentUserControlCentre = new DataViewJourneys(GridEntity);
            currentUserControlRight = new RejseData();
            userControlCentre.Content = currentUserControlCentre;
            userControlRight.Content = currentUserControlRight;
        }

        private void MenuHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dette er et eksempel på løsning af S2 eksamensopgaven Ryg & Rejs", "Om Ryg & Rejs", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}