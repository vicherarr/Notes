using Android.App; // Es buena práctica incluir este using para Bundle
using Android.OS;
using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using NotesApp.Core.ViewModels;

namespace NotesApp.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "Home", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    
    [Register("noteasapp.droid.views.HomeView")]
    public class HomeView : MvxActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle? bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.home_view);
        }
    }
}