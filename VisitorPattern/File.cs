namespace VisitorPattern;

public class File
{
    private string name;
    private double size;

    public File(string name)
    {
        this.setName(name);
        
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public double getSize()
    {
        return size;
    }
}