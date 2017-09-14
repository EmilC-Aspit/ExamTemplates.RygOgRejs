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
    /// Interaction logic for RejseData.xaml
    /// </summary>
    public partial class RejseData : UserControl
    {
        public RejseData()
        {
            InitializeComponent();
            destinationBox.Items.Add(Destination.Billund);
            destinationBox.Items.Add(Destination.Copenhagen);
            destinationBox.Items.Add(Destination.PalmaDeMalkorca);
        }
    }
}
