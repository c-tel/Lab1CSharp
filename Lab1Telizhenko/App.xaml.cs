using Lab1Telizhenko.Managers;
using Lab1Telizhenko.Models;
using Lab1Telizhenko.Windows;
using System.Windows;

namespace Lab1Telizhenko
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Storage storage = new Storage();
            ContentWindow contentWindow = new ContentWindow();
            NavigationModel navigationModel = new NavigationModel(storage, contentWindow);
            NavigationManager.Instance.Initialize(navigationModel);
            contentWindow.Show();
            navigationModel.Navigate(Modes.Welcome);
        }
    }

}
