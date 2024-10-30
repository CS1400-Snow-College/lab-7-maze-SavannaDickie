// See https://aka.ms/new-console-template for more information
//Savanna Dickie
//10/27/2024
//Lab 7 - MAZE

using System.Data;
using System.Net;
//int proposedTop = Console.CursorTop;
//int proposedLeft = Console.CursorLeft;
//int proposedTop = 0;
//int proposedLeft = 0;

Console.WriteLine("Hello Player! Welcome to the MAZE!!\nUse the arrows on your keyboard to navigate the maze.\n");
Console.ReadLine();
string[] mapRows = File.ReadAllLines("map.txt");
Console.Clear();

foreach (string row in mapRows)
{
    Console.WriteLine(row); //keep
    //Console.SetCursorPosition(0,0);
}

Console.SetCursorPosition(0, 0);
//Console.ReadLine();

do
{
    ConsoleKey Key = Console.ReadKey(true).Key;
     if (Key == ConsoleKey.Escape)
    {
    return;
    }


    int cursorTop = Console.CursorTop;
    int cursorLeft = Console.CursorLeft;
   
    if (Key == ConsoleKey.UpArrow)
    {
    cursorTop--;
    
    }
    else if (Key == ConsoleKey.DownArrow)
    {
    cursorTop++;
    
    }
    else if (Key == ConsoleKey.LeftArrow)
    {
    cursorLeft--;
    
    }
    else if (Key == ConsoleKey.RightArrow)
    {
     cursorLeft++;
     
    }
    TryMove(cursorTop, cursorLeft, mapRows);//, out proposedTop, out proposedLeft);
    
        //proposedTop = cursorTop;
        //proposedLeft = cursorLeft;
        //Console.SetCursorPosition(proposedLeft,proposedTop);
    
    //TryMove(proposedTop, proposedLeft, mapRows);
} while (true);

static void TryMove(int cursorTop, int cursorLeft, string[] mapRows)//, out int lastTop, out int lastLeft)
{
    //if(proposedTop >= 0 && proposedTop < Console.BufferHeight && proposedTop < mapRows.Length &&
    //lastTop = cursorTop;
     //   lastLeft = cursorLeft;
       // proposedLeft >= 0 && proposedLeft < Console.BufferWidth && proposedLeft < mapRows[proposedTop].Length)
    //if(proposedTop >= 0 && proposedTop < mapRows.Length && proposedTop < Console.BufferHeight &&
     //   proposedLeft >= 0 && proposedLeft < mapRows[proposedTop].Length && proposedLeft < Console.BufferWidth && mapRows[proposedTop][proposedLeft] != '#')
     if (cursorTop >= 0 && cursorTop < mapRows.Length && cursorLeft >= 0 && cursorLeft < mapRows[cursorTop].Length && 
        mapRows[cursorTop][cursorLeft] != '#' && cursorTop < Console.BufferHeight && cursorLeft < Console.BufferWidth)
    {
        //lastTop = cursorTop;
        //lastLeft = cursorLeft;
        //int proposedTop >= 0;
        //Console.SetCursorPosition(0,0);
         //mapRows[proposedTop][proposedLeft] != '#';
        Console.SetCursorPosition(cursorLeft, cursorTop);

        
        
    }
}

/*int proposedTop = 0;
int proposedLeft = 0;

Console.WriteLine("Hello Player! Welcome to the MAZE!!\nUse the arrows on your keyboard to navigate the maze.\n");
Console.ReadLine();
string[] mapRows = File.ReadAllLines("map.txt");
Console.Clear();

foreach (string row in mapRows)
{
    Console.WriteLine(row); //keep
    //Console.SetCursorPosition(0,0);
}

Console.SetCursorPosition(0, 0);
//Console.ReadLine();

do
{
    ConsoleKey Key = Console.ReadKey(true).Key;
     if (Key == ConsoleKey.Escape)
    {
    return;
    }


    int cursorTop = proposedTop;
    int cursorLeft = proposedLeft;
   
    if (Key == ConsoleKey.UpArrow)
    {
    cursorTop--;
    
    }
    else if (Key == ConsoleKey.DownArrow)
    {
    cursorTop++;
    
    }
    else if (Key == ConsoleKey.LeftArrow)
    {
    cursorLeft--;
    
    }
    else if (Key == ConsoleKey.RightArrow)
    {
     cursorLeft++;
     
    }
    TryMove(cursorTop, cursorLeft, mapRows);//, out proposedTop, out proposedLeft);
    
        proposedTop = cursorTop;
        proposedLeft = cursorLeft;
        Console.SetCursorPosition(proposedLeft,proposedTop);
    
    //TryMove(proposedTop, proposedLeft, mapRows);
} while (true);

static void TryMove(int proposedTop, int proposedLeft, string[] mapRows)//, out int lastTop, out int lastLeft)
{
    //if(proposedTop >= 0 && proposedTop < Console.BufferHeight && proposedTop < mapRows.Length &&
    //lastTop = cursorTop;
     //   lastLeft = cursorLeft;
       // proposedLeft >= 0 && proposedLeft < Console.BufferWidth && proposedLeft < mapRows[proposedTop].Length)
    //if(proposedTop >= 0 && proposedTop < mapRows.Length && proposedTop < Console.BufferHeight &&
     //   proposedLeft >= 0 && proposedLeft < mapRows[proposedTop].Length && proposedLeft < Console.BufferWidth && mapRows[proposedTop][proposedLeft] != '#')
     if (proposedTop >= 0 && proposedTop < mapRows.Length && proposedLeft >= 0 && proposedLeft < mapRows[proposedTop].Length && 
        mapRows[proposedTop][proposedLeft] != '#' && proposedTop < Console.BufferHeight && proposedLeft < Console.BufferWidth)
    {
        //lastTop = cursorTop;
        //lastLeft = cursorLeft;
        //int proposedTop >= 0;
        //Console.SetCursorPosition(0,0);
         //mapRows[proposedTop][proposedLeft] != '#';
        int cursorTop = proposedTop;
        
    }
} */