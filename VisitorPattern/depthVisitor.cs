namespace VisitorPattern;
public class DepthVisitor : IVisitor
{
    public double totalDepth = 0;
    public void Visit(File fi)
    {
        totalDepth = 1;
    }
    public void Visit(Folder fo)
    {
        if (fo.subFolders.Count != 0)
        {
            foreach (Folder sf in fo.subFolders)
            {
                totalDepth++;
            }
        }
    }
}