// See https://aka.ms/new-console-template for more information
//Savanna Dickie
//10/27/2024
//Lab 7 - MAZE

using System.Data;
int cursorTop = Console.CursorTop;
int cursorLeft = Console.CursorLeft;

Console.WriteLine("Hello Player! Welcome to the MAZE!!\nUse the arrows on your keyboard to navigate the maze.\n");
Console.ReadLine();
string[] mapRows = File.ReadAllLines("map.txt");
Console.Clear();
//Console.WriteLine(mapRows);
//Console.SetCursorPosition(0,cursorTop);
//while (string row in mapRows);
foreach (string row in mapRows)
{
    Console.WriteLine(row); //keep
    //Console.SetCursorPosition(0,0);
}
//Console.SetCursorPosition(cursorTop + 1, cursorLeft + 4);
//Console.SetCursorPosition(cursorLeft, cursorTop);
//Console.SetCursorPosition(cursorTop);
Console.SetCursorPosition(0,0);
Console.ReadLine();

do
{
    ConsoleKey Key = Console.ReadKey(true).Key;

    if (Key == ConsoleKey.Escape)
    {
    return;
    }
    else if (Key == ConsoleKey.UpArrow)
    {
    Console.CursorTop--;
    }
    else if (Key == ConsoleKey.DownArrow)
    {
    Console.CursorTop++;
    }
    else if (Key == ConsoleKey.LeftArrow)
    {
        Console.CursorLeft++;
    }
    else if (Key == ConsoleKey.RightArrow)
    {
        Console.CursorLeft++;
    }
} while (true);