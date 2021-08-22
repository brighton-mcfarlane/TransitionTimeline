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
using System.Collections.ObjectModel;

namespace TransitionTimeline
{
    /// <summary>
    /// Interaction logic for LogonPage.xaml
    /// </summary>
    public partial class LogonPage : Window
    {
        public LogonPage()
        {
            InitializeComponent();
        }
        
        private void LogonSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

    public class User
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _branchofservice { get; set; }

        public User(string userName, string passWord, string bos)
        {
            _username = userName;
            _password = passWord;
            _branchofservice = bos;
        }
    }

}
