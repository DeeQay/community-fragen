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

namespace WPF1_Unterfenster
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

        private void OpenWindowButton_Click(object sender, RoutedEventArgs e)
        {
            SubWindow sub = new SubWindow();
            // Sorgt dafür, dass das sub geschlossen wird, wenn das MainWindow geschlossen wird!
            sub.Owner = this;
            sub.Show();
        }

        private void OpenDialogButton_Click(object sender, RoutedEventArgs e)
        {
            SubWindow sub = new SubWindow();
            sub.ShowDialog();
        }
    }
}