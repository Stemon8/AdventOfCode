namespace Day7;

public class MyFile : BasicFile
{
    private string _fileName;
    
    private Folder _parent;

    private int _size;

    public MyFile(string fileName, Folder parent, int size)
    {
        this._fileName = fileName;
        this._parent = parent;
        this._size = size;
    }

    public int GetSize()
    {
        return _size;
    }

    public string GetName()
    {
        return _fileName;
    }
    
    public Folder GetParent()
    {
        return _parent;
    }

    public bool HasParent()
    {
        return !(_parent is null);
    }

}