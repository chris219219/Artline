using System.Collections.ObjectModel;
using Artline.Models;
using Avalonia.Collections;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Artline.ViewModels;

public partial class DataPageViewModel : ViewModelBase
{
    public DataPageViewModel(Database database)
    {
        Database = database;
    }

    public Database Database { get; }
}