using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfMvvmExample.Ui.ViewModel;

internal partial class RichTextBoxWindowViewModel : ObservableObject
{
    private Action<string>? _setText;

    private Func<string>? _getText;

    [ObservableProperty]
    private int _wordCount;

    [ObservableProperty]
    private string _inputText = string.Empty;

    public void InitViewModel(Action<string> setText, Func<string> getText)
    {
        _setText = setText;
        _getText = getText;
    }

    [RelayCommand]
    private void SetText()
    {
        _setText?.Invoke(InputText);
    }

    [RelayCommand]
    private void CountWords()
    {
        var text = _getText?.Invoke() ?? string.Empty;

        WordCount = text.Split([" "], StringSplitOptions.RemoveEmptyEntries).Length;
    }
}