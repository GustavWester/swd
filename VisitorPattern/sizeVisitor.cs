namespace VisitorPattern;
public class SizeVisitor : IVisitor
{
    public double totalSize = 0;
    public void Visit(File fi)
    {
        totalSize += fi.size;
    }
    public void Visit(Folder fo)
    {
        if (fo.files.Count != 0)
        {
            foreach (File fi in fo.files)
            {
                totalSize += fi.size;
            }
        }
        
        if (fo.subFolders.Count != 0)
        {
            foreach (Folder sf in fo.subFolders)
            {
                Visit(sf);
            }
        }
    }
}