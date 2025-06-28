using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using NotesApp.Core.ViewModels;


namespace NotesApp.Touch.Views
{
    public class HomeViewController : MvxViewController<HomeViewModel>
    {
        public HomeViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Configurar la UI programáticamente
            var label = new UILabel
            {
                Text = "Texto por defecto",
                Frame = new CoreGraphics.CGRect(20, 100, 300, 30),
                TextAlignment = UITextAlignment.Center
            };

            var button = new UIButton(UIButtonType.System)
            {
                Frame = new CoreGraphics.CGRect(20, 150, 300, 40),
            };
            button.SetTitle("Presionar", UIControlState.Normal);

            View?.AddSubview(label);
            View?.AddSubview(button);

            var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();
            set.Bind(label).To(vm => vm.Title);
            set.Apply();
        }
    }
}
