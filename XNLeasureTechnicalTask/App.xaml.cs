using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using System.Windows;
using Unity;
using XNLeasureTechnicalTask.Services;
using XNLeasureTechnicalTask.Services.Interfaces;
using XNLeasureTechnicalTask.ViewModels;
using XNLeasureTechnicalTask.ViewModels.Interfaces;
using XNLeasureTechnicalTask.Views;

namespace XNLeasureTechnicalTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    IUnityContainer container = new UnityContainer();
        //    container.RegisterType<ICharacterCountService, CharacterCountService>();
        //    container.RegisterType<IMathService, MathService>();
        //    container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
        //    ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
        //    MainWindow mainWindow = container.Resolve<MainWindow>();
        //    mainWindow.Show();
        //}
        protected override Window CreateShell()
        {
            var mainWindow = Container.Resolve<MainWindow>();
            return mainWindow;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICharacterCountService, CharacterCountService>();
            containerRegistry.Register<IMathService, MathService>();
            containerRegistry.Register<IMainWindowViewModel, MainWindowViewModel>();
            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
        }
    }
}