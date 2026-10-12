using HumanBenchmark.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PropertyChanged;

namespace HumanBenchmark.ViewModels.Sequence;

[AddINotifyPropertyChangedInterface]
    public class SequenceGameViewModel
    {
    public ICommand ChangeTitleCommand { get; private set; }
    public SequenceBoardViewModel GameVM { get; private set; } = new();
    public object Screen { get; private set; }
    public string Title { get; set; }
    public SequenceGameViewModel()
    {
        ChangeTitleCommand = new RelayCommand(_ => Title="Sequence game");
        Screen = GameVM;
    }
}

