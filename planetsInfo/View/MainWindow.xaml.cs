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

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        public string Image
        {
            get => "https://firebasestorage.googleapis.com/v0/b/planets-9419d.appspot.com/o/themes%2FESA_root_pillars.png?alt=media&token=fb981519-c395-40a4-a0cb-decfa0171efd";

        }

  
    }
}
