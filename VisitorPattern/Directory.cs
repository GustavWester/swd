namespace VisitorPattern;

public class Directory
{
    public double size = 1;

    public string name { get; set; }
    
    public Directory(string _name, double _size)
    {
        name = _name;
        size = _size;
    }
}