// See https://aka.ms/new-console-template for more information

using Day7;

Main.VisualRepresentation(Main.ReadFileSystem());

Console.WriteLine("Part1 : "+ Main.Part1(Main.ReadFileSystem()));

Console.WriteLine(30000000 - (70000000-Main.ReadFileSystem().GetSize()));

Console.WriteLine("Part2 : "+ Main.Part2(Main.ReadFileSystem(),Main.ReadFileSystem().GetSize(),30000000 - (70000000-Main.ReadFileSystem().GetSize())));