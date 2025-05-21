using System.Windows.Input;
using Integrity.AI.PayrollMigrator.Services.Services;

namespace Integrity.AI.PayrollMigrator.UI.ViewModels;

public class JsonEditorViewModel
{
    private readonly LangChainService _langChain;
    private readonly BusinessCentralService _bc;

    public JsonEditorViewModel(LangChainService langChain, BusinessCentralService bc)
    {
        _langChain = langChain;
        _bc = bc;
    }

    public string Json { get; set; } = string.Empty;
    public string? Result { get; private set; }

    public ICommand ValidateCommand => new RelayCommand(async _ => Result = string.Join("\n", (await _langChain.ValidateAsync(Json))?.Select(r => r.Message) ?? Array.Empty<string>()));
    public ICommand QueryCommand => new RelayCommand(async q => Result = await _langChain.QueryAsync(Json, q?.ToString() ?? string.Empty));
    public ICommand SubmitCommand => new RelayCommand(async _ => Result = await _bc.SubmitAsync(Json));
}

public class RelayCommand : ICommand
{
    private readonly Func<object?, Task> _execute;
    public event EventHandler? CanExecuteChanged;
    public RelayCommand(Func<object?, Task> execute) => _execute = execute;
    public bool CanExecute(object? parameter) => true;
    public async void Execute(object? parameter) => await _execute(parameter);
}
