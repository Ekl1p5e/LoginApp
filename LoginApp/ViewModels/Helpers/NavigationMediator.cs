using LoginApp.ViewModels.Interfaces;
using System;
using System.Windows.Controls;

namespace LoginApp.ViewModels.Helpers
{
    public delegate void WindowChangeDelegate(Type type);

    public class NavigationMediator : INavigationMediator
    {
        public event WindowChangeDelegate WindowChangeRequested;

        public void ChangeWindow<T>() where T : UserControl
        {
            WindowChangeRequested?.Invoke(typeof(T));
        }
    }
}
