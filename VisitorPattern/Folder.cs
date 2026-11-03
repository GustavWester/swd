namespace VisitorPattern;

public class Folder : Directory, IVisitableElement
{
    
    public List<Folder> subFolders = new();
    public List<File> files = new();

    public Folder(string name, double size) : base(name, size)
    {
        name = base.name;
        size = base.size;
    }
    
    public void Accept(IVisitor visitor) => visitor.Visit(this);
    
    

    

   
    
    
}
    
