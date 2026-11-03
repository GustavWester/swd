namespace VisitorPattern;

public interface IVisitableElement
{
    void Accept(IVisitor visitor);
}