using System;
using System.Linq;
using System.Windows;
using WpfLibrary.Repository;
using WpfLibrary.Models;
using WpfLibrary.Command;
using WpfLibrary.Views;
using System.Windows.Controls;

namespace WpfLibrary.ViewModels
{
    public class BookReviewVM: ViewModel
    {
        public Book Book { get; set; }

        private RelayCommand _backCommand;
        public event EventHandler ClosingRequest;

        public BookReviewVM(Book book)
        {
            Book = book;
        }

        public RelayCommand BackCommand
        {
            get
            {
                return _backCommand ??
                    (_backCommand = new RelayCommand(obj =>
                    {
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }));
            }
        }
    }
}
