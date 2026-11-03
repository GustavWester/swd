namespace VisitorPattern;

public class PrintTreeVisitor : IVisitor
{
    private int depth = 0;

    private void printDepth(int depth)
    {
        while (depth > 0)
        {
            Console.Write(" - ");
            depth--;
        }
    }

    public void Visit(File fi)
    {
        printDepth(depth);
        Console.WriteLine("File: " + fi.name);
    }

    public void Visit(Folder fo)
    {
        printDepth(depth);
        Console.WriteLine($"Folder Name: {fo.name}");
        depth++;

        foreach (File fi in fo.files)
        {
            fi.Accept(this);
        }

        foreach (Folder sf in fo.subFolders)
        {
            sf.Accept(this);
        }
        depth--;
    }
}
