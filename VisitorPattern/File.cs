namespace VisitorPattern;

public class File : Directory, IVisitableElement
{
    public string content = "0101010111000";
    public File(string name, double size) : base(name, size)
    {
        name = base.name;
        size = base.size;
        
    }
    
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}