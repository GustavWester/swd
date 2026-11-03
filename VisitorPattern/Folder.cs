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
    
    public void AddSubFolder(Folder f)
    {

        if (f == null)
        {
            return;
        }
        
        if (!subFolders.Contains(f))
        {
            this.subFolders.Add(f);
        }
        
    }

    public void AddFile(File f)
    {
        
        if (f == null)
        {
            return;
        }
        
        if (!files.Contains(f))
        {
            this.files.Add(f);
        }
    }

    public void printDepth(int depth)
    {
        while (depth > 0)
        {
            Console.Write(" - ");
            depth--;
        }
    }

    public void printFolder(int depth)
    {
        printDepth(depth);
        Console.WriteLine($"Folder Name: {name}");
        depth++;
        
        if (files.Count != 0)
        {
            printDepth(depth);
            foreach (File f in files)
            {
                Console.WriteLine("File: " + f.getName());
            }
        }
        
        if (subFolders.Count != 0)
        {
            foreach (Folder f in this.subFolders)
            {
                f.printFolder(depth);
            }
        }
        
        
        
       
    }
    
    
}
    
