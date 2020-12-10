using Autofac;
using LoginApp.DataAccess;
using LoginApp.DataAccess.Interfaces;
using LoginApp.Models;
using LoginApp.Models.Interfaces;
using LoginApp.ViewModels;
using LoginApp.ViewModels.Helpers;
using LoginApp.ViewModels.Interfaces;
using LoginApp.Views;
using LoginApp.Views.Interfaces;
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
            base.OnStartup(e);

            var builder = new ContainerBuilder();

            builder.RegisterType<RegistrationViewModel>().
                As<IRegistrationViewModel>().
                SingleInstance();

            builder.RegisterType<LoginViewModel>().
                As<ILoginViewModel>().
                SingleInstance();

            builder.RegisterType<LoginListViewModel>().
                As<ILoginListViewModel>().
                SingleInstance();

            builder.RegisterType<MainWindowViewModel>().
                As<IMainWindowViewModel>().
                SingleInstance();

            builder.RegisterType<LoginUserControl>().
                As<ILoginUserControl>().
                SingleInstance();

            builder.RegisterType<RegistrationUserControl>().
                As<IRegistrationUserControl>().
                SingleInstance();

            builder.RegisterType<LoginListUserControl>().
                As<ILoginListUserControl>().
                SingleInstance();

            builder.RegisterType<NavigationMediator>().
                As<INavigationMediator>().
                SingleInstance();

            builder.RegisterType<LoginAccess>().
                As<ILoginAccess>().
                SingleInstance();

            builder.RegisterType<RegistrationAccess>().
                As<IRegistrationAccess>().
                SingleInstance();

            builder.RegisterType<LoginDbContext>().
                As<ILoginDbContext>().
                SingleInstance();

            builder.RegisterType<RegistrationQuery>().
                As<IRegistrationQuery>().
                SingleInstance();

            builder.RegisterType<CurrentUser>().
                As<ICurrentUser>().
                SingleInstance();

            builder.RegisterType<MainWindow>();

            var container = builder.Build();

            var window = container.Resolve<MainWindow>();
            window.ShowDialog();
        }
    }
}
