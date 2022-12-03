
using Day1;

Console.WriteLine("Most calories carried:" + Main.FindMostCaloriesPerElve(Main.SeparateIntoElves(Main.ReadElvesCalories())));

Console.WriteLine("Calories carried by top elves:" + Main.CaloriesCarriedSumDesc(Main.SeparateIntoElves(Main.ReadElvesCalories()),3));

