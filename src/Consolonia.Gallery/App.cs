using System.Globalization;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Consolonia.Gallery.View;
using Consolonia.Themes;

namespace Consolonia.Gallery
{
    internal class App : Application
    {
        static App()
        {
            // we want tests and UI to be executed with same culture
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        public override void OnFrameworkInitializationCompleted()
        {
            /*Styles.Add(new TurboVisionBlackTheme());*/
            /*Styles.Add(new TurboVisionDarkTheme());*/
            /*Styles.Add(new FluentTheme());*/

            if (((ConsoloniaLifetime)ApplicationLifetime).IsRgbColorMode())
                Styles.Add(new MaterialTheme());
            else
                Styles.Add(new TurboVisionTheme());

            if (ApplicationLifetime is ISingleViewApplicationLifetime lifetime)
                lifetime.MainView = new ControlsListView();
            else if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                desktop.MainWindow = new Window { Content = new ControlsListView() };

            base.OnFrameworkInitializationCompleted();
        }
    }
}