namespace Advent.Days;

public partial class Days{
    public async void Day4(){
        Console.WriteLine("Day 4 started!");
        Console.WriteLine("Getting the file...");

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day4.txt");
        int numbers = 0;

        foreach(string inp in input){
            string[] stuff = inp.Split(',');
            string[][] fun = {stuff[0].Split('-'),stuff[1].Split('-')};
            
            //...456... 6-4=2 4
            //..34567.. 7-3=4 3
            if(int.Parse(fun[0][0]) <= int.Parse(fun[1][0]) && int.Parse(fun[0][1]) >= int.Parse(fun[1][1])){
                numbers++;
            }else if(int.Parse(fun[0][0]) >= int.Parse(fun[1][0]) && int.Parse(fun[0][1]) <= int.Parse(fun[1][1])){
                numbers++;
            }
            
        }

        Console.WriteLine($"The number of groups that contain each other is: {numbers}.");//494
        Day4Part2(input);

    }
    ///<summary>
    ///No funky way
    ///</summary>
    private void Day4Part2(string[] input){

        int numbers = 0;


        foreach(string inp in input){
            string[] stuff = inp.Split(',');
            string[][] fun = {stuff[0].Split('-'), stuff[1].Split('-')};
            
            //...456..
            //..345...
            if(int.Parse(fun[0][0]) >= int.Parse(fun[1][0]) && int.Parse(fun[0][0]) <= int.Parse(fun[1][1])){
                //Console.WriteLine($"{fun[0][0]}-{fun[0][1]}  {fun[1][0]}-{fun[1][1]} - left");
                numbers++;
            }else if(int.Parse(fun[1][0]) >= int.Parse(fun[0][0]) && int.Parse(fun[1][0]) <= int.Parse(fun[0][1])){
                //Console.WriteLine($"{fun[0][0]}-{fun[0][1]}  {fun[1][0]}-{fun[1][1]} - right");
                numbers++;
            }

        }
        Console.WriteLine($"The number of groups that overlap each other is: {numbers}"); //833
    }
}