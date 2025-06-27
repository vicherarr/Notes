using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using NotesApp.Droid.SetupApplication;


namespace NotesApp.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, Core.App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}
