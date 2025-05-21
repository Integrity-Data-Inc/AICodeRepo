using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Integrity.AI.PayrollMigrator.Services.Services;
using Integrity.AI.PayrollMigrator.UI.ViewModels;
using Integrity.AI.PayrollMigrator.UI.Views;

namespace Integrity.AI.PayrollMigrator.UI;

public class Program : Application
{
    [STAThread]
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddHttpClient<LangChainService>(c => c.BaseAddress = new Uri("http://localhost:5000"));
        services.AddHttpClient<BusinessCentralService>(c => c.BaseAddress = new Uri("http://localhost:5001"));
        services.AddSingleton<JsonEditorViewModel>();
        var provider = services.BuildServiceProvider();
        var app = new Program();
        var window = new MainWindow(provider.GetRequiredService<JsonEditorViewModel>());
        app.Run(window);
    }
}
