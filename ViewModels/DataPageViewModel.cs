using System.Collections.ObjectModel;
using System.Windows.Input;
using Artline.Models;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Artline.ViewModels;

public partial class DataPageViewModel : ViewModelBase
{
    public DataPageViewModel(Database database)
    {
        Database = database;
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
}