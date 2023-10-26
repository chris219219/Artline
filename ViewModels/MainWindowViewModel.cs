using System;
using System.Collections.Generic;
using Artline.Models;
using Artline.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Artline.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        _database.Projects.Add(new Project("Sample Project", new Client("Chris", ClientType.Individual), "Test", 5.12m, ProjectPriority.Low) { CompletionPercent = 0.5m });

        Action<string> changePageAction = ChangePage;

        _pages = new()
        {
            { nameof(DataPageView), new DataPageViewModel(changePageAction, _database) },
            { nameof(ProjectPageView), new ProjectPageViewModel() }
        };

        CurrentPage = _pages[nameof(DataPageView)];
    }

    private readonly Dictionary<string, ViewModelBase> _pages;
    [ObservableProperty]
    private ViewModelBase? _currentPage;

    private readonly Database _database = new();

    private void ChangePage(string viewName)
    {
        CurrentPage = _pages[viewName];
    }
}
