namespace VisitorPattern;

public class Folder
{
    private string name;
    public Folder[] subFolders;
    public File[] files;

    public Folder(string name)
    {
        this.SetName(name);
        files = new File[] { };
        subFolders = new Folder[] { };
    }
    

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void AddSubFolder(Folder f)
    {

        if (f == null)
        {
            return;
        }
        
        if (!subFolders.Contains(f))
        {
            this.subFolders[this.subFolders.Length - 1] = f;
        }
        
        
    }

    public void AddFile(File f)
    {
        if (!files.Contains(f))
        {
            this.files[this.files.Length] = f;
        }
        
        else
        {
            return;
        }
        
        
    }

    public void printFolder()
    {

        if (this.files != null)
        {
            foreach (File f in this.files)
            {
                Console.WriteLine("File:" + f.getName());
            }
        }
        
        if (subFolders.Length != 0)
        {
            foreach (Folder f in this.subFolders)
            {
                Console.WriteLine("Folder: " + f.GetName());
                f.printFolder();
                return;
            }

        }

        return;
    }
    
}