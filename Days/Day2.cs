namespace Advent.Days;

public partial class Days{
    private async void Day2(){

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
            {"X", 1}, //Lose
            {"Y", 2}, //Tie
            {"Z", 3}  //Win
        };
        int score = 0;

        foreach(string inp in input){
            string[] game = inp.Split(" ");

            score += ((plays[game[1]] - 1) * 3);

            if(plays[game[1]] == 3){
                score += (plays[game[0]] + 1) == 4 ? 1 : (plays[game[0]] + 1);
                //score += (plays[game[0]]);
            }if(plays[game[1]] == 2){
                score += plays[game[0]];
            }else{
                score += (plays[game[0]] - 1) == 0 ? 3 : (plays[game[0]] - 1);
            }
        }
        //10761 is too high!
        Console.WriteLine("The score for Part 2 is {0}!", score);
    }
}