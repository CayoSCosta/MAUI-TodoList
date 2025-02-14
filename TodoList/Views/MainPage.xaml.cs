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
    public void OnTaskConcluded(object sender, EventArgs e)
    {
        var task = ((SwipeItem)sender).BindingContext as TaskItem;
        if (task != null)
        {
            var viewModel = (MainViewModel)BindingContext;
            viewModel.CompletedTasks(task);
        }
    }

    // Evento para arquivar a tarefa
    public void OnTaskArchived(object sender, EventArgs e)
    {
        var task = ((SwipeItem)sender).BindingContext as TaskItem;
        if (task != null)
        {
            var viewModel = (MainViewModel)BindingContext;
            viewModel.ArchiveTask(task);
        }
    }
}
