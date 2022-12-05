// See https://aka.ms/new-console-template for more information

using Day5;

Console.WriteLine("Part 1 message : " + Main.ReadTopCrate(Main.ReadOrders(Main.GetLines(),Main.GetCrateStacks(Main.GetLines()))));
Console.WriteLine("Part 2 message : " + Main.ReadTopCrate(Main.ReadOrdersP2(Main.GetLines(),Main.GetCrateStacks(Main.GetLines()))));
