using LoginApp.Models.Interfaces;
using LoginApp.ViewModels.Base;
using LoginApp.ViewModels.Interfaces;
using System;

namespace LoginApp.ViewModels
{
    public class LoginListViewModel : ViewModelBase, ILoginListViewModel
    {
        private readonly INavigationMediator _mediator;
        private readonly ICurrentUser _currentUser;

        public LoginListViewModel(
            INavigationMediator mediator,
            ICurrentUser currentUser)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
        }
    }
}
