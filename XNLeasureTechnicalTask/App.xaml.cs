using System.Windows;
using Unity;
using XNLeasureTechnicalTask.Services;
using XNLeasureTechnicalTask.Services.Interfaces;

namespace XNLeasureTechnicalTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICharacterCountService, CharacterCountService>();
            container.RegisterType<IMathService, MathService>();

            MainWindow mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}