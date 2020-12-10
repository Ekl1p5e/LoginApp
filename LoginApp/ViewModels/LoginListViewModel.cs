using LoginApp.DataAccess.Interfaces;
using LoginApp.Models;
using LoginApp.Models.Interfaces;
using LoginApp.ViewModels.Base;
using LoginApp.ViewModels.Commands;
using LoginApp.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LoginApp.ViewModels
{
    public class LoginListViewModel : ViewModelBase, ILoginListViewModel
    {
        private readonly INavigationMediator _mediator;
        private readonly ILoginAccess _loginAccess;
        private readonly ICurrentUser _currentUser;

        private List<LoginTimeInfo> _logins;

        public LoginListViewModel(
            INavigationMediator mediator,
            ILoginAccess loginAccess,
            ICurrentUser currentUser)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _loginAccess = loginAccess ?? throw new ArgumentNullException(nameof(loginAccess));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
        }

        public ICommand ShowLoginsCommand
        {
            get
            {
                return new BasicCommand(c => ShowLogins(), c => true);
            }
        }

        public ICommand LogOutCommand
        {
            get
            {
                return new BasicCommand(c => Logout(), c => true);
            }
        }

        public List<LoginTimeInfo> LoginTimes
        {
            get => _logins;
            set => SetProperty(ref _logins, value);
        }

        private void Logout()
        {
            LoginTimes.Clear();

            _currentUser.Logout();
        }

        private void ShowLogins()
        {
            LoginTimes = _loginAccess.GetLogins(_currentUser.UserId).ToList();
        }
    }
}
