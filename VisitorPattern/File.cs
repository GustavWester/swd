namespace VisitorPattern;

public class File : Directory, IVisitableElement
{
    public File(string name, double size) : base(name, size)
    {
        name = base.name;
        size = base.size;
        
    }
    
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}