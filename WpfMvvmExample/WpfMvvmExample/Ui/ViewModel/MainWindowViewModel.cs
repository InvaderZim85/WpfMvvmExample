using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfMvvmExample.Ui.View;

namespace WpfMvvmExample.Ui.ViewModel;

internal partial class MainWindowViewModel : ObservableObject
{
    private const string DefaultText = "To open a window click on one of the buttons...";

    [ObservableProperty] 
    private string _info = DefaultText;

    [ObservableProperty]
    private string _log = string.Empty;

    [RelayCommand]
    private void OpenBasicControlWindow()
    {
        Info = "Basic Controls open...";

        var window = new BasicControlsWindow();
        window.ShowDialog();

        Info = string.Empty;
        AddLogMessage("Basic controls window opened.");
    }

    [RelayCommand]
    private void OpenRichTextBoxWindow()
    {
        Info = "RichTextBox window open...";

        var window = new RichTextBoxWindow();
        window.ShowDialog();

        Info = string.Empty;
        AddLogMessage("RichTextBox window opened.");
    }

    private void AddLogMessage(string message)
    {
        Log += $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message} {Environment.NewLine}";
    }
}