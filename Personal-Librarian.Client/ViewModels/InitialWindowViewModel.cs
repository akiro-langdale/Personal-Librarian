using Personal_Librarian.Client.ViewModels.Base;
using System.Reflection;
using System.Windows;

namespace Personal_Librarian.Client.ViewModels
{
    public class InitialWindowViewModel : ViewModelBase
    {
        public InitialWindowViewModel()
        {
            _title = "Personal-Librarian";
            _version = "Версия: " + Convert.ToString(Assembly.GetExecutingAssembly().GetName().Version);
        }        

        #region Title : string? - Title

        /// <summary> Fields - Title </summary>
        private string? _title;

        /// <summary> Properties - Title </summary>
        public string? Title { get => _title; set => Set(ref _title, value); }

        #endregion

        #region Version : string? - Version

        /// <summary> Fields - Version </summary>
        private string? _version;

        /// <summary> Properties - Version </summary>
        public string? Version { get => _version; set => Set(ref _version, value); }

        #endregion
    }
}
