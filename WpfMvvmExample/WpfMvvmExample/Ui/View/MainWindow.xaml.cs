using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmExample.Ui.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        TextBoxLog.ScrollToEnd();
    }
}