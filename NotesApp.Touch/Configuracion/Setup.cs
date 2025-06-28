using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using NotesApp.Core;
using Serilog.Extensions.Logging;


namespace NotesApp.Touch.Configuracion
{
    public class Setup : MvxIosSetup<App> // App es tu clase MvxApplication en el Core
    {
        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            return new App();
        }

        protected override void InitializeFirstChance(IMvxIoCProvider iocProvider)
        {
            base.InitializeFirstChance(iocProvider);
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            return new SerilogLoggerFactory();
        }

        protected override ILoggerProvider? CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }
    }
}
