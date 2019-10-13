using Microsoft.Extensions.Logging;

namespace MonkeyConf.Wasm
{
    public class Program
	{
		static int Main(string[] args)
		{
            ConfigureFilters(Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory);

            Windows.UI.Xaml.Application.Start(_ => new UWP.App());

			return 0;
		}

        static void ConfigureFilters(ILoggerFactory factory)
        {
#if DEBUG
            factory
                .WithFilter(new FilterLoggerSettings
                    {
                        { "Uno", LogLevel.Warning },
                        { "Windows", LogLevel.Warning }
					}
                )
                .AddConsole(LogLevel.Trace);
#else
            factory
                .AddConsole(LogLevel.Error);
#endif
        }
    }
}