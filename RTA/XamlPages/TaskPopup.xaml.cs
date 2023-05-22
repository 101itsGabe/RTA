using Library.App.Services;
using RTA.ViewModels;
using CommunityToolkit.Maui.Views;

namespace RTA.XamlPages;

public partial class TaskPopup : Popup
{
    public TaskPopup()
    {
        InitializeComponent();
        BindingContext = new TaskPopupViewModel();
    }
    void OnTextChanged(object sender, EventArgs e)
    {
        (BindingContext as TaskPopupViewModel).curTask.taskDesc = ((Entry)sender).Text;
    }

    public void Button_Close(object sender, EventArgs e)
    {
        Close();
    }

    private void AddTask_Button(object sender, EventArgs e)
    {
        TaskService t = TaskService.Current;
        (BindingContext as TaskPopupViewModel).curTask.taskName += (t.Tasks.Count + 1).ToString();
        t.Tasks.Add((BindingContext as TaskPopupViewModel).curTask);
        Close();

    }

}