using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ConsoloniaAppTemplate;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnExit(object sender, RoutedEventArgs e)
    {
        Close();
    }
}