using LoginApp.DataAccess.Interfaces;
using LoginApp.Models;
using LoginApp.Models.Interfaces;
using LoginApp.ViewModels.Base;
using LoginApp.ViewModels.Commands;
using LoginApp.ViewModels.Interfaces;
using LoginApp.Views;
using System;
using System.Windows.Input;

namespace LoginApp.ViewModels
{
    public class LoginViewModel : ViewModelBase, ILoginViewModel
    {
        private readonly INavigationMediator _mediator;
        private readonly ILoginAccess _loginAccess;
        private readonly ICurrentUser _currentUser;

        private string _emailAddress;
        private string _password;

        public LoginViewModel(
            INavigationMediator mediator,
            ILoginAccess loginAccess,
            ICurrentUser currentUser)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _loginAccess = loginAccess ?? throw new ArgumentNullException(nameof(loginAccess));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
        }

        public string EmailAddress
        {
            get => _emailAddress;
            set => SetProperty(ref _emailAddress, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand RegisterCommand
        {
            get
            {
                return new BasicCommand(c => _mediator.ChangeWindow<RegistrationUserControl>(), c => true);
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new BasicCommand(c => Login(new LoginInfo
                {
                    UserName = EmailAddress,
                    Password = Password,
                }), c => true);
            }
        }

        private void Login(LoginInfo loginInfo)
        {
            bool success = _loginAccess.Login(loginInfo);
            if (success)
            {
                _currentUser.Update(loginInfo.UserName);

                _mediator.ChangeWindow<LoginListUserControl>();
            }
        }
    }
}
