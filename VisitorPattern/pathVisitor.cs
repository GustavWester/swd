namespace VisitorPattern;

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