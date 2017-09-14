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
    /// Interaction logic for DataViewJourneys.xaml
    /// </summary>
    public partial class DataViewJourneys: UserControl
    {
        public DataViewJourneys(List<DataGridEnitty> testEntities)
        {
            InitializeComponent();
            JourneyRepository dl = new JourneyRepository();
            dataGridJourneys.ItemsSource = dl.GetAll(); //
        }

        private void TextBoxFilterJourneys_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
