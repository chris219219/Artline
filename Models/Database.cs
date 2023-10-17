using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Tmds.DBus.Protocol;

namespace Artline.Models;

public class Database : ObservableObject
{
    public const string SaveLocation = "ArtlineData";
    public const string ProjectsFilename = "projects.json";
    public const string ClientsFilename = "clients.json";

    public Database()
    {
        
    }

    public ObservableCollection<Project> Projects { get; } = new();
    public ObservableCollection<Client> Clients { get; } = new();

    public async Task Save()
    {
        if (!Directory.Exists(SaveLocation)) Directory.CreateDirectory(SaveLocation);
        string s = JsonSerializer.Serialize(Projects);
        await File.WriteAllTextAsync(Path.Combine(SaveLocation, ProjectsFilename), s);
        s = JsonSerializer.Serialize(Clients);
        await File.WriteAllTextAsync(Path.Combine(SaveLocation, ClientsFilename), s);
    }

    public async Task<bool> Load()
    {
        string s = await File.ReadAllTextAsync(Path.Combine(SaveLocation, ProjectsFilename));
        var loadedProjects = JsonSerializer.Deserialize<ObservableCollection<Project>>(s);
        if (loadedProjects is null) return false;
        foreach (var project in loadedProjects) Projects.Add(project);

        s = await File.ReadAllTextAsync(Path.Combine(SaveLocation, ClientsFilename));
        var loadedClients = JsonSerializer.Deserialize<ObservableCollection<Client>>(s);
        if (loadedClients is null) return false;
        foreach (var client in loadedClients) Clients.Add(client);
        return true;
    }
}