using Lab1Telizhenko.Models;
using Lab1Telizhenko.ViewModels;
using System.Windows.Controls;

namespace Lab1Telizhenko.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView(Storage storage)
        {
            InitializeComponent();
            var viewModel = new MainViewModel(storage);
            DataContext = viewModel;
        }
    }
}
