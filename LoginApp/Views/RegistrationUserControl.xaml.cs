using LoginApp.ViewModels.Interfaces;
using LoginApp.Views.Interfaces;
using System.Windows.Controls;

namespace LoginApp.Views
{
    /// <summary>
    /// Interaction logic for RegistrationUserControl.xaml
    /// </summary>
    public partial class RegistrationUserControl : UserControl, IRegistrationUserControl
    {
        public RegistrationUserControl(IRegistrationViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        public UserControl ContentWindow => this;
    }
}
