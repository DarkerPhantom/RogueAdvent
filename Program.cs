using System;
using Advent;

namespace Advent;
public class Starter{
    public static async Task Main(){

        
        Console.Clear();
        Console.WriteLine("Which day should be run?");

        int input = int.Parse(await GetInputAsync());
        
        
        
        if(input==0){
            Console.Clear();
            await Main();
        }else{
            Console.Clear();
            Console.WriteLine($"Running day {input}!");
            Day1.Day();
            await GetInputAsync();
        }
        
    }

    public static async Task<string> GetInputAsync(){
        string? input = await Console.In.ReadLineAsync();
        
        if(int.TryParse(input, out int date)){
            return input;
        }else{
            return "0";
        }
           
    }
}