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

    public void AddFile(File fi)
    {
        if (fi == null)
        {
            return;
        }
        if (!files.Contains(fi))
        {
            this.files.Add(fi);
        }
    }

    public void AddSubFolder(Folder fo)
    {
        if (fo == null)
        {
            return;
        }
        if (!subFolders.Contains(fo))
        {
            this.subFolders.Add(fo);
        }
    }
}
