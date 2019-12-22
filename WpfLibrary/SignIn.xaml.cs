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
using WpfLibrary.ViewModels;

namespace WpfLibrary.Views
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        SignInVM pageVM = new SignInVM();
        public SignIn()
        {
            InitializeComponent();
            DataContext = pageVM;
            pageVM.ClosingRequest += (s, e) => Close();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AdminPasswordBox.Visibility = Visibility.Visible;
            Lbl1.Visibility = Visibility.Visible;
        }
        private void AdminPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            AdminPanel adminpage = new AdminPanel();
            adminpage.Show();
        }
    }
}
