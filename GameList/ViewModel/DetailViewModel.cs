using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GameList.ViewModel;

[QueryProperty("Text","Text")]
public partial class DetailViewModel: ObservableObject
 {
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task Back()
    {
        await Shell.Current.GoToAsync("..");
    }
 }

