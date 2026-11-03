namespace VisitorPattern;

public class PrintTreeVisitor : IVisitor
{   
    private void printDepth(int depth)
    {
        while (depth > 0)
        {
            Console.Write(" - ");
            depth--;
        }
    }

    public void printTree(int depth)
    {
        printTree(depth);
        Console.WriteLine($"Folder Name: {name}");
        depth++;
        
        if (files.Count != 0)
        {
            printDepth(depth);
            foreach (File fi in files)
            {
                Console.WriteLine("File: " + fi.getName());
            }
        }
        
        if (subFolders.Count != 0)
        {
            foreach (Folder fo in this.subFolders)
            {
                fo.printTree(depth);
            }
        } 
    }
}