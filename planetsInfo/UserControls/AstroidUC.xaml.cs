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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace planetsInfo
{
    /// <summary>
    /// Interaction logic for AstroidUC.xaml
    /// </summary>
    public partial class AstroidUC : UserControl
    {
        public AstroidViewModel AstroidViewModel { get; set; }
        public AstroidUC()
        {
            InitializeComponent();
            //AstroidViewModel = astroidvm;
            //this.DataContext = AstroidViewModel;
        }
    }
}
