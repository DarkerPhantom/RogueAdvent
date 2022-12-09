namespace Advent.Days;
public partial class Days{
    
    public static void Day(int inp){
        Days days = new Days();
        /*
        var Dict = new Dictionary<int,Days>(){
            {1, new Days{}}
        };*/
        
        switch(inp){
            case 1:
                days.Day1();
            break;
            case 2:
                days.Day2();
            break;
            case 3:
                days.Day3();
            break;
            case 4:
                days.Day4();
            break;
            case 5:
                days.Day5();
            break;
            case 6:
                days.Day6();
            break;
            case 7:
                days.Day7();
            break;
        }

    }
    private async void Day1(){

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