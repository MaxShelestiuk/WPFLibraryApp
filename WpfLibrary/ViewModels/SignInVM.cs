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
    public class SignInVM : ViewModel
    {
        private string _login;
        private string _password;

        private RelayCommand _loginCommand;
        private RelayCommand _signUpCommand;
        private RelayCommand _passwordCommand;

        public event EventHandler ClosingRequest;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ??
                    (_loginCommand = new RelayCommand(obj =>
                    {
                        using (LibraryContext Context = new LibraryContext())
                        {
                            PersonRepository PersonRepository = new PersonRepository(Context);

                            Person person = PersonRepository.GetAll(p => (p.Login == Login && p.Password == Password)).FirstOrDefault();

                            if (person == null)
                            {
                                MessageBox.Show("Login or Password is not correct. Maybe there is no such user.");
                            }
                            else
                            {
                                if (person.IsAdmin)
                                {
                                    AdminPanel adminpanel = new AdminPanel(/*ref person*/);
                                    adminpanel.Show();
                                }
                                else
                                {
                                    Reader reader = (Reader)person;
                                    Cabinet cab = new Cabinet(ref reader);
                                    cab.Show();
                                }

                                Context.SaveChanges();

                                ClosingRequest?.Invoke(this, EventArgs.Empty);
                            }
                        }
                    }));
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

        public RelayCommand SignUpCommand
        {
            get
            {
                return _signUpCommand ??
                    (_signUpCommand = new RelayCommand(obj =>
                    {
                        SignUp registration = new SignUp();
                        registration.Show();
                    }));
            }
        }

        public SignInVM()
        {
            //using (LibraryContext Context = new LibraryContext())
            //{
            //    ReaderRepository readerRepository = new ReaderRepository(Context);
            //    PersonRepository PersonRepository = new PersonRepository(Context);
            //    PersonRepository.Create(new Person{Login="max", Password="111", IsAdmin=true});
            //    readerRepository.Create(new Reader { Login = "ivan", Password = "222", IsAdmin = false });
            //    readerRepository.Create(new Reader { Login = "carl", Password = "333", IsAdmin = false });
            //}
        }
    }
}
