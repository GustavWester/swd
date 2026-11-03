namespace VisitorPattern;
public class DepthVisitor : IVisitor
{
    public double totalDepth = 0;
    private double currentDepth = 0;
    public void Visit(File fi){}
    public void Visit(Folder fo)
    {
        currentDepth++;
        if (currentDepth > totalDepth)
        {
            totalDepth = currentDepth;
        }
        if (fo.subFolders.Count != 0)
        {
            foreach (Folder sf in fo.subFolders)
            {
                Visit(sf);
            }
        }
        currentDepth--;
    }
}