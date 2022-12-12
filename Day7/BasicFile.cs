namespace Day7;

public interface BasicFile
{
    public int GetSize();

    public Folder GetParent();

    public bool HasParent();

    public string GetName();
}