using System.Windows;
using Integrity.AI.PayrollMigrator.UI.ViewModels;

namespace Integrity.AI.PayrollMigrator.UI.Views;

public partial class MainWindow : Window
{
    public MainWindow(JsonEditorViewModel vm)
    {
        InitializeComponent();
        DataContext = vm;
    }
}
