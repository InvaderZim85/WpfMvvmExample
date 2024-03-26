using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfMvvmExample.Ui.ViewModel;

internal partial class BasicControlsWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _labelText = "Value: /";

    [ObservableProperty]
    private string _textBoxText = string.Empty;

    [RelayCommand]
    private void ButtonClick()
    {
        LabelText = $"Value: {TextBoxText}";
    }
}