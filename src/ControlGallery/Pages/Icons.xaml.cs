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

namespace ControlGallery.Pages
{
    /// <summary>
    /// Interaction logic for Icons.xaml
    /// </summary>
    public partial class Icons : UserControl
    {
        public Icons()
        {
            InitializeComponent();
        }

        private void IconButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
    }
}
