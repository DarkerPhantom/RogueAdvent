namespace Advent.Days;

public partial class Days{
    public async void Day3(){
        Console.Clear();
        Console.WriteLine("Day 3 started!");
        Console.WriteLine("Getting the file...");

        var dict = new Dictionary<char, int>{
            {'a', 1}, {'b', 2}
        };

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day3.txt");
        int priorities = 0;
        int COut = 0;

        Console.WriteLine(input.GetLength(0));

        foreach(string inp in input){
            string[] compartments = {inp.Substring(0,inp.Length/2), inp.Substring(inp.Length/2)};
            char[][] items = {
                compartments[0].ToCharArray(),
                compartments[1].ToCharArray()
            };

            for(int i = 0; i < items[0].Length; i++){
                for(int j = 0; j < items[1].Length; j++){
                    char found = items[0][i] == items[1][j] ? items[0][i] : ' ';
                    
                    if(found != ' '){
                        COut++;
                        priorities += char.IsLower(found) ? (int)found - 96 : (int)found - 38;
                        //Console.WriteLine(found + " " + char.IsLower(found) + " " + (char.IsLower(found) ? (int)found - 96 : (int)found - 38));
                        //Console.WriteLine(found + " " + COut);
                        break;
                    }
                }
            }
            

            
        }
        //7493 is too low
        Console.WriteLine(priorities);
    }
} 