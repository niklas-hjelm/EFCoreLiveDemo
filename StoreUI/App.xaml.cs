using System.Configuration;
using System.Data;
using System.Windows;
using DataAccess;

namespace StoreUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ApplicationContextManager.Initialize(new ProductContext());
        }

        protected override void OnExit(ExitEventArgs e)
        {
            ApplicationContextManager.Context?.Dispose();
        }
    }

}
