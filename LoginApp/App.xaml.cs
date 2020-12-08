using System;
using System.Windows;

namespace LoginApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.StartupUri = new Uri(@"Views\MainWindow.xaml", UriKind.Relative);

            base.OnStartup(e);
        }
    }
}
