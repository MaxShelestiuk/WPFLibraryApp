using System;
using System.Collections.Generic;
using System.Linq;
using WpfLibrary.Repository;
using WpfLibrary.Models;
using WpfLibrary.Command;
using WpfLibrary.Views;


namespace WpfLibrary.ViewModels
{
    public class CabinetVM : ViewModel
    {
        public Reader Reader { get; set; }
        private List<Book> _books;
        private Book _selectedBook;

        private RelayCommand _takeBookCommand;
        private RelayCommand _showBookCommand;
        private RelayCommand _bookReviewCommand;

        public event EventHandler ClosingRequest;

        public CabinetVM(Reader reader)
        {
            Reader = reader;
            //using (LibraryContext Context = new LibraryContext())
            //{
            //    //Chapter chap1 = new Chapter { Bookid = 1, Name = "Introduction", Number = 1, StartPage = 5 };
            //    //Chapter chap12 = new Chapter { Bookid = 1, Name = "Beginning", Number = 2, StartPage = 34 };
            //    //Chapter chap2 = new Chapter { Bookid = 2, Name = "Introduction2", Number = 1, StartPage = 7 };
            //    //Chapter chap21 = new Chapter { Bookid = 2, Name = "Beginning2", Number = 2, StartPage = 36 };              
            //}
            //UpdateBooks();
        }

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                Book book = SelectedBook;
                BookReview bookrev = new BookReview(ref book);
                bookrev.Show();
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public List<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        public List<Book> GetBooksForReader(Reader reader)
        {
            List<Book> books = new List<Book>();

            using (LibraryContext Context = new LibraryContext())
            {
                ReaderCardRepository readercardrep = new ReaderCardRepository(Context);
                BookRepository booksrep = new BookRepository(Context);

                foreach (ReaderCard rc in readercardrep.GetAll(i => i.Reader.Id == reader.Id))
                {
                    books.Add(booksrep.GetById(rc.Idbook));
                }
            }
            return books;
        }
        public void UpdateBooks()
        {
            using (LibraryContext Context = new LibraryContext())
            {
                Books = GetBooksForReader(Reader);
            }
        }

        public RelayCommand TakeBookCommand
        {
            get
            {
                return _takeBookCommand ??
                    (_takeBookCommand = new RelayCommand(obj =>
                    {
                        BookReview bookrev = new BookReview();
                        bookrev.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand ShowBookCommand
        {
            get
            {
                return _showBookCommand ??
                    (_showBookCommand = new RelayCommand(obj =>
                    {
                        UpdateBooks();
                    }
                    ));
            }
        }
    }
}
