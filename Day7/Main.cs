using System.Collections;

namespace Day7;

public class Main
{
    public static Folder ReadFileSystem()
    {
        Folder root = null;
        string[] lines = File.ReadAllLines ("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day7/input.txt");
        Folder currentFolder;
        currentFolder = null;
        for (int i = 0; i < lines.Length; i++)
        {
            switch (lines[i].Split(" ")[1])
            {
                case "cd":
                    if (currentFolder is null)
                    {
                        currentFolder = new Folder(lines[i].Split(" ")[2], null);
                        root = currentFolder;
                    }
                    else
                    {
                        if (lines[i].Split(" ")[2].Equals(".."))
                        {
                            currentFolder = currentFolder.GetParent();
                        }
                        else
                        {
                            currentFolder = currentFolder.GetFolder(lines[i].Split(" ")[2]);
                        }
                        
                    }
                    break;
                case "ls":
                    if (currentFolder == null)
                    {
                        currentFolder = new Folder("/", null);
                        root = currentFolder;
                    }
                    while (i + 1 < lines.Length && !(lines[i + 1].Split(" ")[0].Equals("$")))
                    {
                        i++;
                        if (lines[i].Split(" ")[0].Equals("dir"))
                        {
                            currentFolder.AddChild(new Folder(lines[i].Split(" ")[1],currentFolder));
                        }
                        else
                        {
                            currentFolder.AddChild(new MyFile(lines[i].Split(" ")[1],currentFolder,int.Parse(lines[i].Split(" ")[0])));
                        }
                    }
                    break;
            }
        }

        return root;
    }

    public static void VisualRepresentation(Folder folder)
    {
        VisualRepresentation(folder, 0);
    }


    public static void VisualRepresentation(Folder folder,int indentation)
    {
        string str = "";
        for (int i = 0; i < indentation; i++)
        {
            str += " ";
        }
        Console.WriteLine(str + "   |-- "+folder.GetName() + " - " + folder.GetSize());
        foreach (MyFile file in folder.GetFiles())
        {
            Console.WriteLine(str + "   |-- " + file.GetName() + " - " + file.GetSize());
        }

        foreach (Folder fdr in folder.GetFolders())
        {
            VisualRepresentation(fdr,indentation+3);
        }
    }

    public static int Part1(Folder folder)
    {
        int total = 0;
        if (folder.GetSize() <= 100000)
        {
            total += folder.GetSize();
        }

        foreach (Folder fdr in folder.GetFolders())
        {
            total += Part1(fdr);
        }

        return total;
    }
    
    public static int Part2(Folder folder, int min, int tofree)
    {
        if (folder.GetSize() > tofree)
        {
            foreach (Folder fdr in folder.GetFolders())
            {
                if (fdr.GetSize() > tofree && fdr.GetSize() < min)
                {
                    min = fdr.GetSize();
                }
                min = Part2(fdr, min, tofree);
            }
        }

        return min;
    }
    


}