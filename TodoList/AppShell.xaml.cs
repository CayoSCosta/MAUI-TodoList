using Microsoft.Maui.Controls;
using TodoList.ViewModels;

namespace TodoList;

public partial class AppShell : Shell
{
    private MainViewModel _mainViewModel = new MainViewModel();
    public AppShell()
    {
        InitializeComponent();
        BindingContext = _mainViewModel;
    }
}
