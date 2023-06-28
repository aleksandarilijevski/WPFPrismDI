using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using System.Windows.Controls;
using WPFPrismDI.Services;
using WPFPrismDI.Services.Interface;

namespace WPFPrismDI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            MainWindow w = Container.Resolve<MainWindow>();
            return w;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDatabaseService, DatabaseService>();
        }
    }
}
