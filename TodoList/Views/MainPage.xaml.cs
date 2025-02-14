using TodoList.ViewModels;

namespace TodoList.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    // Evento para concluir a tarefa
    private void OnArchiveTaskInvoked(object sender, EventArgs e)
    {
        if (sender is SwipeItem swipeItem)
        {
            if (swipeItem.BindingContext is TaskItem task)
            {
                var viewModel = (MainViewModel)BindingContext;
                viewModel.ArchiveTask(task);
            }
        }
    }

    private void OnCompleteTaskInvoked(object sender, EventArgs e)
    {
        if (sender is SwipeItem swipeItem)
        {
            if (swipeItem.BindingContext is TaskItem task)
            {
                var viewModel = (MainViewModel)BindingContext;
                viewModel.CompleteTask(task);
            }
        }
    }
}
