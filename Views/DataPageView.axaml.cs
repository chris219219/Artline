using Artline.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Artline.Views;

public partial class DataPageView : UserControl
{
    public DataPageView()
    {
        InitializeComponent();
    }

    private void OnProjectSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (DataContext is DataPageViewModel vm)
        {
            vm.EditProjectButtonEnabled = e.AddedItems.Count == 1;
            vm.DeleteProjectButtonEnabled = e.AddedItems.Count > 0;
        }
    }

    private void OnClientSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (DataContext is DataPageViewModel vm)
        {
            vm.EditClientButtonEnabled = e.AddedItems.Count == 1;
            vm.DeleteClientButtonEnabled = e.AddedItems.Count > 0;
        }
    }
}