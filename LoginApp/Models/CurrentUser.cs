using LoginApp.Models.Interfaces;
using LoginApp.ViewModels.Interfaces;
using LoginApp.Views;
using System;

namespace LoginApp.Models
{
    public class CurrentUser : ICurrentUser
    {
        private readonly INavigationMediator _mediator;

        public CurrentUser(INavigationMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void Update(string userName)
        {
            UserId = userName;
        }

        public void Logout()
        {
            UserId = null;

            _mediator.ChangeWindow<LoginUserControl>();
        }

        public string UserId { get; private set; }
    }
}
