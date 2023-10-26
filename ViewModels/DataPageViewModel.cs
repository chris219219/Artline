using System;
using Artline.Models;
using Artline.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Artline.ViewModels;

public partial class DataPageViewModel : ViewModelBase
{
    public DataPageViewModel(Action<string> changePageAction, Database database)
    {
        Database = database;
        _changePageAction = changePageAction;
    }

    public Database Database { get; }

    [ObservableProperty]
    private bool _editProjectButtonEnabled = false;

    [ObservableProperty]
    private bool _deleteProjectButtonEnabled = false;

    [ObservableProperty]
    private bool _editClientButtonEnabled = false;

    [ObservableProperty]
    private bool _deleteClientButtonEnabled = false;

    private Action<string> _changePageAction;

    public void AddProject()
    {
        _changePageAction.Invoke(nameof(ProjectPageView));
    }
}