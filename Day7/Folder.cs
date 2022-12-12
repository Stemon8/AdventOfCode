namespace Day7;

public class Folder : BasicFile
{
    private string _fileName;
    
    private Folder _parent;
 
    private IDictionary<string,Folder> _subFolders = new Dictionary<string,Folder>();
    private IDictionary<string,MyFile> _subFiles = new Dictionary<string,MyFile>();
    

    public Folder(string fileName, Folder parent)
    {
        this._fileName = fileName;
        this._parent = parent;
    }

    public Folder GetParent()
    {
        return _parent;
    }

    public bool HasParent()
    {
        return !(_parent is null);
    }

    public string GetName()
    {
        return _fileName;
    }

    public int GetSize()
    {
        int total = 0;
        foreach (BasicFile child in _subFolders.Values)
        {
            total += child.GetSize();
        }
        foreach (BasicFile child in _subFiles.Values)
        {
            total += child.GetSize();
        }

        return total;
    }

    public void AddChild(Folder child)
    {
        _subFolders.Add(child.GetName(),child);
    }

    public void AddChild(MyFile child)
    {
        _subFiles.Add(child.GetName(),child);
    }

    public Folder GetFolder(string name)
    {
        return _subFolders[name];
    }

    public ICollection<Folder> GetFolders()
    {
        return _subFolders.Values;
    }
    
    public ICollection<MyFile> GetFiles()
    {
        return _subFiles.Values;
    }

}