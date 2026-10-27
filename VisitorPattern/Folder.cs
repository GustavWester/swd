namespace VisitorPattern;

public class Folder
{
    private string name;
    private List<Folder> subFolders = new();
    private List<File> files = new();

    public Folder(string name)
    {
        this.SetName(name);
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
            this.subFolders.Add(f);
        }
        
    }

    public void AddFile(File f)
    {
        if (!files.Contains(f))
        {
            this.files.Add(f);
        }
        
        else
        {
            return;
        }
        
        
    }

    public void printFolder()
    {
        Console.WriteLine($"Folder Name: {name}");

        if (this.files != null)
        {
            foreach (File f in this.files)
            {
                Console.WriteLine("File:" + f.getName());
            }
        }
        
        if (subFolders.Count != 0)
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