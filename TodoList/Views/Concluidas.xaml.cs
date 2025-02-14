using TodoList.ViewModels;

namespace TodoList.Views;

public partial class Concluidas : ContentPage
{
	public Concluidas(MainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}