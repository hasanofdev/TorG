using Autofac;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Data;
using System.Windows;
using TorG.Navigations;
using TorG.Repositories;
using TorG.ViewModels;
using TorG.Views;
using IContainer = Autofac.IContainer;

namespace TorG
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer? Container { get; private set; }

        public void ApplicationStartup(object sender, StartupEventArgs e)
        {

            NavigationStore navigationStore = new NavigationStore();
            var builder = new ContainerBuilder();

            builder.RegisterInstance(navigationStore).SingleInstance();

            builder.RegisterType<MainViewModel>();
            builder.RegisterType<HomeViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<AdminPanelViewModel>();

            Container = builder.Build();

            navigationStore.CurrentViewModel = Container.Resolve<AdminPanelViewModel>();
            MainView mainView = new();

            mainView.DataContext = Container.Resolve<MainViewModel>();

            mainView.Show();



        }
    }

}
