namespace VisitorPattern;

public class CopyVisitor : IVisitor
{
    public Directory copy;
    public void Visit(File fi)
    {
        copy = new File(fi.name, fi.size);
    }
    public void Visit(Folder fo)
    {
        Folder newFolder = new Folder(fo.name, fo.size);
        foreach (File fi in fo.files)
        {
            Visit(fi);
            newFolder.AddFile((File)copy);
        }
        foreach (Folder sf in fo.subFolders)
        {
            Visit(sf);
            newFolder.AddSubFolder((Folder)copy);
        }
        copy = newFolder;
    }
}
    
    
