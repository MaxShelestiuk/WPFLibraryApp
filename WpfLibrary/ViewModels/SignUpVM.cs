using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfLibrary.Repository;
using WpfLibrary.Models;
using WpfLibrary.Command;
using WpfLibrary.Views;
using System.Windows.Controls;

namespace WpfLibrary.ViewModels
{
    public class SignUpVM:ViewModel
    {
        private string _name;
        private string _surname;
        private int _number;
        private string _login;
        private string _password;

        private RelayCommand _signUp;
        private RelayCommand _passwordCommand;
        private RelayCommand _backCommand;
        public event EventHandler ClosingRequest;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public RelayCommand PasswordCommand
        {
            get
            {
                return _passwordCommand ??
                    (_passwordCommand = new RelayCommand(obj =>
                    {
                        PasswordBox passwordBox = obj as PasswordBox;
                        Password = passwordBox.Password;
                    }
                    ));
            }
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

        public RelayCommand SignUp
        {
            get
            {

                return _signUp ??
                    (_signUp = new RelayCommand(obj => {
                        using (LibraryContext Context = new LibraryContext())
                        {
                            ReaderRepository readerRepository = new ReaderRepository(Context);
                            var readers = readerRepository.GetAll();
                            foreach (Reader r in readers)
                            {
                                if (r.Login == Login && r.Password == Password)
                                {
                                    MessageBox.Show("User already exists");
                                    return;
                                }
                            }

                            var reader = new Reader()
                            {
                                Name = this.Name,
                                Surname = this.Surname,
                                Phone = this.Number,
                                Login = this.Login,
                                Password = this.Password
                            };

                            readerRepository.Create(reader);
                            Context.SaveChanges();

                            Cabinet mycabinet = new Cabinet(ref reader);
                            mycabinet.Show();

                            ClosingRequest?.Invoke(this, EventArgs.Empty);
                        }
                    }));
            }
        }
    }
}
