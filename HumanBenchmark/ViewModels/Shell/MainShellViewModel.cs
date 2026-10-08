using HumanBenchmark.Commands;
using HumanBenchmark.ViewModels.Sequence;
using PropertyChanged;
using System.Windows.Input;

namespace HumanBenchmark.ViewModels.Shell;

[AddINotifyPropertyChangedInterface]
public class MainShellViewModel
{

    public object CurrentGame { get; set; } = new SequenceGameViewModel();

    public string Title { get; set; }
    public MainShellViewModel()
    {
        Title = "Standardvärde";
        
    }

    private void ChangeTitle(string title)
    {
        Title = title;
    }
}

