namespace VisitorPattern;

public class AddSubfolderVisitor : IVisitor
{
    public void Visit(Folder fo)
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