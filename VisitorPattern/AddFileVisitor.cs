namespace VisitorPattern;
public class AddFileVisitor : IVisitor
{
    public void Visit(File fi)
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
}