using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Artline.Models;

public enum ProjectPriority
{
    Low, Medium, High, Urgent
}

public partial class Project : ObservableObject
{

    public static readonly HashSet<string> ProjectTypes = new();

    public Project(string name, Client client, string projectType, decimal revenue, ProjectPriority priority)
    {
        _name = name;
        _client = client;
        _projectType = projectType;
        _revenue = revenue;
        _priority = priority;
        _listingDate = DateOnly.FromDateTime(DateTime.Now);
    }

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private Client _client;

    [ObservableProperty]
    private string _projectType;

    [ObservableProperty]
    private Euro _revenue;

    [ObservableProperty]
    private ProjectPriority _priority;

    [ObservableProperty]
    private Percent _completionPercent = 0m;

    [ObservableProperty]
    private DateOnly _listingDate;

    [ObservableProperty]
    private DateOnly? _dueDate;

    [ObservableProperty]
    private string? _notes;
}