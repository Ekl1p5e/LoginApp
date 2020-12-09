using LoginApp.ViewModels.Base;
using LoginApp.ViewModels.Interfaces;
using LoginApp.Views;
using LoginApp.Views.Interfaces;
using System;
using System.Windows.Controls;

namespace LoginApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel, IDisposable
    {
        private readonly INavigationMediator _mediator;
        private readonly ILoginUserControl _loginControl;
        private readonly ILoginListUserControl _loginListControl;
        private readonly IRegistrationUserControl _registrationControl;

        private UserControl _contentWindow;

        public MainWindowViewModel(
            INavigationMediator mediator,
            ILoginUserControl loginControl,
            ILoginListUserControl loginListControl,
            IRegistrationUserControl registrationControl)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _loginControl = loginControl ?? throw new ArgumentNullException(nameof(loginControl));
            _loginListControl = loginListControl ?? throw new ArgumentNullException(nameof(loginListControl));
            _registrationControl = registrationControl ?? throw new ArgumentNullException(nameof(registrationControl));

            _mediator.WindowChangeRequested += WindowChangeRequestedCallback;
            ContentWindow = _loginControl.ContentWindow;
        }

        private void WindowChangeRequestedCallback(Type type)
        {
            switch (type.Name)
            {
                case nameof(LoginUserControl):
                    ContentWindow = _loginControl.ContentWindow;
                    break;
                case nameof(LoginListUserControl):
                    ContentWindow = _loginListControl.ContentWindow;
                    break;
                case nameof(RegistrationUserControl):
                    ContentWindow = _registrationControl.ContentWindow;
                    break;
            }
        }

        public UserControl ContentWindow
        {
            get => _contentWindow;
            set => SetProperty(ref _contentWindow, value);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
