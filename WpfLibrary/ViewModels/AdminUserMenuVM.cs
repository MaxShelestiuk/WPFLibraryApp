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
    public class AdminUserMenuVM : ViewModel
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
    }
}
