namespace VisitorPattern;

public class File : Directory, IVisitableElement
{
    public File(string name, double size) : base(name, size)
    {
        name = base.name;
        size = base.size;
        
    }
    
    public void Accept(IVisitor visitor) => visitor.Visit(this);

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