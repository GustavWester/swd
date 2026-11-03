namespace VisitorPattern;
public interface IVisitor
{
    void Visit(File fi);
    void Visit(Folder fo);
}