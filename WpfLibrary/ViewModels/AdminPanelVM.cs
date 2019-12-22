using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLibrary.Repository;
using WpfLibrary.Models;
using WpfLibrary.Command;
using WpfLibrary.Views;

namespace WpfLibrary.ViewModels
{
    public class AdminPanelVM : ViewModel
    {
        private RelayCommand _userMenuCommand;
        private RelayCommand _bookMenuCommand;
        private RelayCommand _authorMenuCommand;
        private RelayCommand _toMainPageCommand;
        private RelayCommand _connAuthBookCommand;
        private RelayCommand _orderCommand;
        private RelayCommand _backCommand;

        public event EventHandler ClosingRequest;

        public RelayCommand UserMenuCommand
        {
            get
            {
                return _userMenuCommand ??
                    (_userMenuCommand = new RelayCommand(obj =>
                    {
                        AdminUserMenu usermenu = new AdminUserMenu();
                        usermenu.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand BookMenuCommand
        {
            get
            {
                return _bookMenuCommand ??
                    (_bookMenuCommand = new RelayCommand(obj =>
                    {
                        AdminBookMenu bookmenu = new AdminBookMenu();
                        bookmenu.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand AuthorMenuCommand
        {
            get
            {
                return _authorMenuCommand ??
                    (_authorMenuCommand = new RelayCommand(obj =>
                    {
                        AdminAuthorMenu authormenu = new AdminAuthorMenu();
                        authormenu.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand ConnAuthBookCommand
        {
            get
            {
                return _connAuthBookCommand ??
                    (_connAuthBookCommand = new RelayCommand(obj =>
                    {
                        AdminAuthorBookConnection authorBookConnection = new AdminAuthorBookConnection();
                        authorBookConnection.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand OrderCommand
        {
            get
            {
                return _orderCommand ??
                    (_orderCommand = new RelayCommand(obj =>
                    {
                        AdminOrders orders = new AdminOrders();
                        orders.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }
                    ));
            }
        }

        public RelayCommand ToMainPage
        {
            get
            {
                return _toMainPageCommand ??
                    (_toMainPageCommand = new RelayCommand(obj =>
                    {
                        Cabinet cab = new Cabinet();
                        cab.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
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
    }
}
