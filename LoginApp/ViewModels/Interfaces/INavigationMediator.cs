using LoginApp.ViewModels.Helpers;
using System.Windows.Controls;

namespace LoginApp.ViewModels.Interfaces
{
    public interface INavigationMediator
    {
        event WindowChangeDelegate WindowChangeRequested;

        void ChangeWindow<T>() where T : UserControl;
    }
}
