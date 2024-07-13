using Microsoft.Extensions.DependencyInjection;

namespace Personal_Librarian.Client.Services.Implementations
{
    public class UserDialogServices : IUserDialog
    {
        private readonly IServiceProvider _service;
        public UserDialogServices(IServiceProvider service) => _service = service;

        private MainWindow? _mainWindow;

        public void OpenMainWindow()
        {
            if (_mainWindow is { } window)
            {
                window.Show();
                return;
            }

            window = _service.GetRequiredService<MainWindow>();
            window.Closed += (_, _) => _mainWindow = null;

            _mainWindow = window;
            window.Show();
        }
    }
}
