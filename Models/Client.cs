using CommunityToolkit.Mvvm.ComponentModel;

namespace Artline.Models;

public enum ClientType
{
    Individual, Company
}

public partial class Client : ObservableObject
{
    public Client(string name, ClientType type)
    {
        _name = name;
        _type = type;
    }

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private ClientType _type;

    [ObservableProperty]
    private string? _notes;
}