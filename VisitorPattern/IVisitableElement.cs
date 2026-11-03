namespace VisitorPattern;

public interface IVisitableElement
{
    void Accept(IVisitor visitor);
}

public interface IVisitor
{
    void Visit(File f);
    void Visit(Folder f);
}


public class SizeVisitor : IVisitor
{
    public double totalSize = 0;
    public void Visit(File fi)
    {
        totalSize += fi.size;
    }
    public void Visit(Folder fo)
    {
        totalSize += fo.size;
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

public class PathVisitor : IVisitor
{
    public string path = "";
    public void Visit(File fi)
    {
        path = "/" +  fi.name;
    }
    public void Visit(Folder fo)
    {
        path  += "/" + fo.name;
        if (fo.subFolders.Count != 0)
        {
            foreach (Folder sf in fo.subFolders)
            {
                path  += "/" + sf.name;
                if (sf == fo)
                {
                    path = "/" +  sf.name;
                }
                else if  (sf != fo)
                { 
                    Visit(sf);
                }
                else
                {
                    path = "";
                }
            }
        }
    }
}

