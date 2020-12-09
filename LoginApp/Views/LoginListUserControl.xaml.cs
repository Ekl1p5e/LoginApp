using LoginApp.ViewModels.Interfaces;
using LoginApp.Views.Interfaces;
using System.Windows.Controls;

namespace LoginApp.Views
{
    /// <summary>
    /// Interaction logic for LoginListUserControl.xaml
    /// </summary>
    public partial class LoginListUserControl : UserControl, ILoginListUserControl
    {
        public LoginListUserControl(ILoginListViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        public UserControl ContentWindow => this;
    }
}
