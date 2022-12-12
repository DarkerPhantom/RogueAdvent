namespace Advent.Days;

public partial class Days{
    public async void Day3(){
        Console.Clear();
        Console.WriteLine("Day 3 started!");
        Console.WriteLine("Getting the file...");

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day3.txt");
        int priorities = 0;
        bool found = false;

        foreach(string inp in input){
            string[] compartments = {inp.Substring(0,inp.Length/2), inp.Substring(inp.Length/2)};

            foreach(char i in compartments[0]){

                foreach(char j in compartments[1]){
                    if(i == j){
                        found = true;
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
        Console.WriteLine($"The sum of the priorities in Part 1 is {priorities}"); //7850
        Day3Part2(input);
    }

    private void Day3Part2(string[] input){
        int priorities = 0;
        bool found = false;

        for(int a = 0; a < input.GetLength(0); a+=3){
            foreach(char i in input[a]){
                foreach(char j in input[a+1]){
                    foreach(char k in input[a+2]){
                        if(i==j && j==k){
                            priorities += char.IsLower(i) ? (int)i - 96 : (int)i - 38;
                            found = true;
                            break;
                        }
                    }
                    if(found){
                        break;
                    }
                }
                if(found){
                    found = false;
                    break;
                }
            }
        }
        Console.WriteLine($"The sum of the priorities in Part 2 is {priorities}");
    }
} 