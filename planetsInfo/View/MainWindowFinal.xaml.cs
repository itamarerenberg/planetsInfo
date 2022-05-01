using MaterialDesignThemes.Wpf;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace planetsInfo.View
{
    /// <summary>
    /// Interaction logic for MainWindowFinal.xaml
    /// </summary>
    public partial class MainWindowFinal : Window
    {
        public MainWindowFinal()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}
