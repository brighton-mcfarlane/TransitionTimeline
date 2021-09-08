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

namespace TransitionTimeline
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

        private void PastDueButton_Click(object sender, RoutedEventArgs e)
        {
            if (PastDueButton.Background == Brushes.Transparent)
            {
                PastDueButton.Background = Brushes.LightSteelBlue;

            }else if (PastDueButton.Background == Brushes.LightSteelBlue)
            {
                PastDueButton.Background = Brushes.Transparent;
            }
        }

        private void CurrentButton_Click(object sender, RoutedEventArgs e)
        {
            PastDueButton.Background = Brushes.LightSteelBlue;
        }

        private void UpcomingButton_Click(object sender, RoutedEventArgs e)
        {
            PastDueButton.Background = Brushes.LightSteelBlue;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
