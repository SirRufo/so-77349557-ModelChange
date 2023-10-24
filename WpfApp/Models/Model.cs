namespace WpfApp.Models
{
    public partial class Model : ReactiveObject
    {
        [Reactive] public int Age { get; set; }
        [Reactive] public string Name { get; set; } = string.Empty;
        [Reactive] public string Family { get; set; } = string.Empty;
    }
}
