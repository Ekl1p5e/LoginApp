using LoginApp.DataAccess.Interfaces;
using LoginApp.Models.Entities;
using LoginApp.ViewModels.Base;
using LoginApp.ViewModels.Commands;
using LoginApp.ViewModels.Interfaces;
using LoginApp.Views;
using System;
using System.Windows.Input;

namespace LoginApp.ViewModels
{
    public class RegistrationViewModel : ViewModelBase, IRegistrationViewModel
    {
        private readonly INavigationMediator _mediator;
        private readonly IRegistrationAccess _registrationAccess;

        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private string _password;
        private string _confirmPassword;

        public RegistrationViewModel(
            INavigationMediator mediator,
            IRegistrationAccess registration)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _registrationAccess = registration ?? throw new ArgumentNullException(nameof(registration));
        }

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
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

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => SetProperty(ref _confirmPassword, value);
        }

        public ICommand SubmitCommand
        {
            get
            {
                return new BasicCommand(c => SubmitRegistration(new Registration
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    EmailAddress = EmailAddress,
                    Password = Password,
                }), c => true);
            }
        }

        public ICommand ResetCommand
        {
            get
            {
                return new BasicCommand(c => ClearFields(), c => true);
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                return new BasicCommand(c => _mediator.ChangeWindow<LoginUserControl>(), c => true);
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new BasicCommand(c => _mediator.ChangeWindow<LoginUserControl>(), c => true);
            }
        }

        public void SubmitAction()
        {

        }

        public void ResetAction()
        {

        }

        private void ClearFields()
        {
            FirstName = null;
            LastName = null;
            EmailAddress = null;
            Password = null;
            ConfirmPassword = null;
        }

        private void SubmitRegistration(Registration registration)
        {
            _registrationAccess.Register(registration);
        }
    }
}
