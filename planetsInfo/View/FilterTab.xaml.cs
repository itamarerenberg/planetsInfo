using planetsInfo.Model;
using planetsInfo.ViewModels;
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

namespace planetsInfo.View
{
    /// <summary>
    /// Interaction logic for FilterTab.xaml
    /// </summary>
    public partial class FilterTabWindow : Window
    {
        public FilterTabWindow(Action<FilterAstroParams_M> filter)
        {
            InitializeComponent();
            this.DataContext = new NEOUC_VM(this, filter);
        }
    }
}
