using System.Reactive;

using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive] public Model MyModel { get; set; } = new();
        public ReactiveCommand<Unit, Unit> TestCommand { get; }

        public MainWindowViewModel()
        {
            var canExecuteTestCommand = this.WhenAnyValue(
                e => e.MyModel.Age,
                e => e.MyModel.Name,
                ( age, name ) => age > 0 && !string.IsNullOrEmpty( name ) );
            TestCommand = ReactiveCommand.Create( OnTestCommand, canExecuteTestCommand );
        }

        private void OnTestCommand()
        {
            MessageBox.Show( "Hi" );
        }
    }
}