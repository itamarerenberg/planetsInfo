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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace planetsInfo.UserControls
{
    /// <summary>
    /// Interaction logic for SearchPanelUserControl.xaml
    /// </summary>
    public partial class SearchPanelUserControl : UserControl
    {
        public SearchPanelUserControl()
        {
            InitializeComponent();
            DataContext = new SearchResultPanelViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ucSearchItem.Visibility = Visibility.Visible;
            lvItems.Visibility = Visibility.Visible;
            DataContext = new SearchResultPanelViewModel(tbSearch.Text.ToString());
        }
    }
}
