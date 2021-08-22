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
using TransitionTimeline.Properties;
using System.Collections.ObjectModel;
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
            LogonPage userLogon = new LogonPage();
            userLogon.ShowDialog();
        }

        private void GetUserInfo(LogonPage user)
        {
            string username = user.UsernameBox.Text;
            string password = user.PasswordBox.Password;
            string branchofservice = user.BranchSelect.SelectedItem.ToString();
        }

        private void PastDueButton_Click(object sender, RoutedEventArgs e)
        {
            PastDueButton.Background = Brushes.DarkGray;
        }

        private void CurrentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpcomingButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
