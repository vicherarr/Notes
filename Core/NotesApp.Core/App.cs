using MvvmCross.IoC;
using MvvmCross.ViewModels;
using NotesApp.Core.ViewModels;

namespace NotesApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("ViewModel")
                .AsInterfaces()
                .RegisterAsDynamic();

            CreatableTypes()
                .EndingWith("Managers")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
