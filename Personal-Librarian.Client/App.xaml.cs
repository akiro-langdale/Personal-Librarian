using Microsoft.Extensions.DependencyInjection;
using Personal_Librarian.Client.Services;
using Personal_Librarian.Client.Services.Implementations;
using Personal_Librarian.Client.ViewModels;
using System.Windows;

namespace Personal_Librarian.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private static IServiceProvider? _services;

        public static IServiceProvider services => _services ??= InitializeServices().BuildServiceProvider();

        private static IServiceCollection InitializeServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<InitialWindowViewModel>();

            services.AddSingleton<IUserDialog, UserDialogServices>();

            services.AddTransient(
                s =>
                {
                    var model = s.GetRequiredService<InitialWindowViewModel>();
                    var window = new InitialWindow { DataContext = model };

                    return window;
                });

            return services;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            services.GetRequiredService<IUserDialog>().OpenInitialWindow();

        }
    }
}
