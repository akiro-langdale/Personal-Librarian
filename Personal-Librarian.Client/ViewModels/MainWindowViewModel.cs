using Personal_Librarian.Client.ViewModels.Base;

namespace Personal_Librarian.Client.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _title = "Main Window";
        }

        #region Title : string? - Title

        /// <summary> Fields - Title </summary>
        private string? _title;

        /// <summary> Properties - Title </summary>
        public string? Title { get => _title; set => Set(ref _title, value); }

        #endregion
    }
}
