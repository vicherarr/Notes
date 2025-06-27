using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using NotesApp.Core;
using Serilog.Extensions.Logging;


namespace NotesApp.Droid.SetupApplication
{
    public class Setup : MvxAndroidSetup<App>
    {
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
