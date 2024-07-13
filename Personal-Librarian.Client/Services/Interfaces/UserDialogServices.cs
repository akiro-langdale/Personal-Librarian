using Microsoft.Extensions.DependencyInjection;

namespace Personal_Librarian.Client.Services.Implementations
{
    public class UserDialogServices : IUserDialog
    {
        private readonly IServiceProvider _service;
        public UserDialogServices(IServiceProvider service) => _service = service;

        private InitialWindow? _initialWindow;

        public void OpenInitialWindow()
        {
            if (_initialWindow is { } window)
            {
                window.Show();
                return;
            }

            window = _service.GetRequiredService<InitialWindow>();
            window.Closed += (_, _) => _initialWindow = null;

            _initialWindow = window;
            window.Show();
        }
    }
}
