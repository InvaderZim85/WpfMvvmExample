using System.Windows;
using System.Windows.Documents;
using WpfMvvmExample.Ui.ViewModel;

namespace WpfMvvmExample.Ui.View;

/// <summary>
/// Interaction logic for RichTextBoxWindow.xaml
/// </summary>
public partial class RichTextBoxWindow : Window
{
    public RichTextBoxWindow()
    {
        InitializeComponent();
    }

    private void RichTextBoxWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        if (DataContext is RichTextBoxWindowViewModel viewModel)
            viewModel.InitViewModel(SetText, GetText);
    }

    private void SetText(string text)
    {
        RichTextBoxControl.AppendText(text);
    }

    private string GetText()
    {
        return new TextRange(RichTextBoxControl.Document.ContentStart, RichTextBoxControl.Document.ContentEnd).Text;
    }
}