using MvvmCross.ViewModels;


namespace NotesApp.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private string _title = "Welcome to NotesApp";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public HomeViewModel() 
        {
            Title = "Que tal, esto es una prueba";
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
