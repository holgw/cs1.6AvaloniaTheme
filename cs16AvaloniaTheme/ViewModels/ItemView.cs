namespace cs16AvaloniaTheme.ViewModels;

public class ItemView
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ItemView(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
