namespace Advent.Days;

public partial class Days{
    private async void Day2(){

        Console.Clear();
        Console.WriteLine("Day 2 Started!");
        Console.WriteLine("Getting the file...");

        string[] input = await System.IO.File.ReadAllLinesAsync(@"/workspaces/RogueAdvent/Resources/Day2.txt");
        int score = 0;

        var plays = new Dictionary<string, int>(){
            {"X", 1},
            {"Y", 2},
            {"Z", 3},
            {"A", 1},
            {"B", 2},
            {"C", 3}
        };

        foreach(string inp in input){
            string[] game = inp.Split(" ");

            if(game[1] == "X"){
                score++;
            }else if (game[1] == "Y"){
                score += 2;
            }else{
                score += 3;
            }

            if((plays[game[1]] - plays[game[0]]) == 1 || (plays[game[1]] - plays[game[0]]) == -2){
                score += 6;
            }else if(plays[game[1]] == plays[game[0]]){
                score += 3;
            }
        }
        Console.WriteLine($"Your score for Part 1 is {score}!");
        
        Day2Part2(input);
    }

    private void Day2Part2(string[] input){
        var plays = new Dictionary<string, int>{
            {"A", 1}, //Rock
            {"B", 2}, //Paper
            {"C", 3}, //Scissors 
            {"X", 0}, //Lose
            {"Y", 3}, //Tie
            {"Z", 6}  //Win
        };

        int score = 0;

        foreach(string inp in input){
            string[] game = inp.Split(" ");

            score += plays[game[1]];

            if(plays[game[1]] == 6){//If I want to win
                score += (plays[game[0]] + 1) == 4 ? 1 : (plays[game[0]] + 1);
                //Console.Write($"{(plays[game[0]] + 1) == 4} ");
            }else if(plays[game[1]] == 3){//If I want to tie
                score += plays[game[0]];
                //Console.Write(plays[game[0]]);
            }else{//If I want to lose
                score += (plays[game[0]] - 1) == 0 ? 3 : (plays[game[0]] - 1);
                //Console.Write((plays[game[0]] - 1) == 0 ? 3 : (plays[game[0]] - 1));
            }
            //Console.WriteLine(game[0] + " " + game[1] + " = " + score);
        }
        //9975
        Console.WriteLine("Your score for Part 2 is {0}!", score);
    }
}