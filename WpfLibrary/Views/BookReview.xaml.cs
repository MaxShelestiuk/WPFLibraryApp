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
    /// Interaction logic for BookReview.xaml
    /// </summary>
    public partial class BookReview : Window
    {
        public BookReview()
        {
            InitializeComponent();
        }
        public BookReview(ref Book selectedBook)
        {
            InitializeComponent();
            BookReviewVM bookReviewVM = new BookReviewVM(selectedBook);
            DataContext = bookReviewVM;
            bookReviewVM.ClosingRequest += (s, e) => Close();
        }
    }
}
