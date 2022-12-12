namespace Advent.Days;

public partial class Days{
    public async void Day3(){
        Console.Clear();
        Console.WriteLine("Day 3 started!");
        Console.WriteLine("Getting the file...");

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day3.txt");
        int priorities = 0;
        bool found = false;
        int COut = 0;

        Console.WriteLine(input.GetLength(0));

        foreach(string inp in input){
            string[] compartments = {inp.Substring(0,inp.Length/2), inp.Substring(inp.Length/2)};

            Console.WriteLine(compartments[0] + " " + compartments[1]);

            foreach(char i in compartments[0]){

                foreach(char j in compartments[1]){

                    if(i == j){
                        Console.WriteLine(i);
                        found = true;
                        COut++;
                        priorities += char.IsLower(i) ? (int)i - 96 : (int)i - 38;
                        break;
                    }

                }
                if(found){
                    found = false;
                    break;
                }                

            }
            
        }

        Console.WriteLine(COut);

        //7493 is too low, 10599 is too high
        Console.WriteLine(priorities);
    }
} 