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
        //TODO: Detta finns för att vi inte har gått igenom Service Provider i .NET Core än.
        protected override void OnStartup(StartupEventArgs e)
        {
            ApplicationContextManager.Initialize(new ProductContext());
        }

        //TODO: Detta finns för att vi inte har gått igenom Service Provider i .NET Core än.
        protected override void OnExit(ExitEventArgs e)
        {
            ApplicationContextManager.Context?.Dispose();
        }
    }

}
