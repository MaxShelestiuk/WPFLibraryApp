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
using WpfLibrary.Models;

namespace WpfLibrary.Views
{
    /// <summary>
    /// Interaction logic for Cabinet.xaml
    /// </summary>
    public partial class Cabinet : Window
    {
        public Cabinet()
        {
            InitializeComponent();
        }
        public Cabinet(ref Reader reader)
        {
            InitializeComponent();
            CabinetVM cabinet = new CabinetVM(reader);
            DataContext = cabinet;
            cabinet.ClosingRequest += (s, e) => Close();
        }
        //private void ButtonTakeBook_Click(object sender, RoutedEventArgs e)
        //{
        //    Catalogue catal = new Catalogue();
        //    this.NavigationService.Navigate(catal);
        //}

        //private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        //{
        //    BookReview mybook = new BookReview();
        //    //this.NavigationService.Navigate(mybook);
        //}
    }
}
