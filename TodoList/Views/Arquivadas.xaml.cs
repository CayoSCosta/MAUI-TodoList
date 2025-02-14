using TodoList.ViewModels;

namespace TodoList.Views;

public partial class Arquivadas : ContentPage
{
	public Arquivadas(MainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}