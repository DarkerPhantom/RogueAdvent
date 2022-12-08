using System.IO;

namespace Advent;

public class Day1{
    public static async void Day(){

        Console.Clear();
        Console.WriteLine("Day 1 Started!");
        Console.WriteLine("Getting the file...");
        
        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day1.txt");
        
        int maxval = 0;
        int finval = 0;

        Console.WriteLine(input.GetLength(0));

        for(int i = 0; i<input.GetLength(0); i++){
            if(input[i] == ""){
                //Console.WriteLine("Found a break!");
                if(finval > maxval){
                    maxval = finval;   
                }
                finval = 0;
            }
            int.TryParse(input[i],out int val);
            finval += val;
        }
        
        Console.WriteLine($"Maximum calories: {maxval}");

    }
    
}