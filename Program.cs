// See https://aka.ms/new-console-template for more information
//Savanna Dickie
//10/27/2024
//Lab 7 - MAZE

using System.Data;

Console.WriteLine("Hello Player! Welcome to the MAZE!!\nUse the arrows on your keyboard to navigate the maze.\n");
Console.ReadLine();
string[] mapRows = File.ReadAllLines("map.txt");
Console.Clear();
//Console.WriteLine(mapRows);

//while (string row in mapRows);
foreach (string row in mapRows)
{
    Console.WriteLine(row); //keep
}
