using Avalonia.Controls;
using MyAvaloniaApp.Models;
using MyAvaloniaApp.ViewModels;

namespace MyAvaloniaApp.Views;

public partial class WindowTovar : Window
{
    public WindowTovar()
    {
        InitializeComponent();
        DataContext = new TovarViewModel();
    }
}