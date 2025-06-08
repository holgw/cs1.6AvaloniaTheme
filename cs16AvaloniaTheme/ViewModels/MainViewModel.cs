namespace cs16AvaloniaTheme.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public ItemView[] Items { get; set; } =
    [
        new ItemView(475456, "Dog"),
        new ItemView(2890, "Dolphin"),
        new ItemView(267433443, "Cat"),
    ];
}