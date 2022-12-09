namespace Advent.Days;

public partial class Days{
    public async void Day3(){
        Console.Clear();
        Console.WriteLine("Day 2 started!");
        Console.WriteLine("Getting the file...");

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day3.txt");

        foreach(string inp in input){
            string[] compartments = {inp.Substring(0,inp.Length/2), $""};
            Console.WriteLine($"Compartment 1: {compartments[0]}, Compartment 2: {compartments[1]}");
        }
    }
}