using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Hangman1
{

    public class Program 
    {
        public static void Main()
        {
        	
        	var list = new List <string> ();
        	list.Add("tirane");
        	list.Add("jerevat");
        	list.Add("vienna");
        	list.Add("baku");
        	list.Add("minsk");
        	list.Add("brussels");
        	list.Add("sarajevo");
        	list.Add("sofia");
        	list.Add("zagreb");
        	list.Add("nicosia");
        	list.Add("prague");
        	list.Add("copenhagen");
        	list.Add("tallinn");
        	list.Add("helsinki");
        	list.Add("paris");
        	list.Add("tblisi");
        	list.Add("berlin");
        	list.Add("athens");
        	list.Add("budapest");
        	list.Add("reykjavik");
        	list.Add("rome");
        	list.Add("riga");
        	list.Add("vadus");
        	list.Add("vilnius");
        	list.Add("luxemburg");
        	list.Add("skopje");
        	list.Add("valletta");
        	list.Add("kishinev");
        	list.Add("monaco");
        	list.Add("amsterdam");
        	list.Add("oslo");
        	list.Add("belfast");
        	list.Add("warsaw");
        	list.Add("lisbon");
        	list.Add("bucharest");
        	list.Add("moscow");
        	list.Add("esinburgh");
        	list.Add("bratislava");
        	list.Add("ljubljana");
        	list.Add("madrid");
        	list.Add("stockholm");
        	list.Add("berne");
        	list.Add("kiev");
        	list.Add("london");
        	list.Add("belgrade");
        	string f;
        	f="yes";
        	do
        	{
        		Console.WriteLine("A HANGMAN GAME");
        	var generator = new Random();
        	int a = generator.Next(45);
        	Console.WriteLine(list[a]);
        	Console.WriteLine("Which European capital this is?");
        	Console.WriteLine("(use only small letters)");
        	Console.WriteLine("");
        	switch(a)
        	{
        		case 0:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 1:
        		Console.WriteLine("_ _ _ _ _ _ _");
        		break;
        		case 2:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 3:
        		Console.WriteLine("_ _ _ _");
        		break;
        		case 4:
        		Console.WriteLine("_ _ _ _ _");
        		break;
        		case 5:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 6:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 7:
        		Console.WriteLine("_ _ _ _ _");
        		break;
        		case 8:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 9:
        		Console.WriteLine("_ _ _ _ _ _ _");
        		break;
        		case 10:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 11:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
        		break;
        		case 12:
        		Console.WriteLine("_ _ _ _ _ _ _");
        		break;
        		case 13:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 14:
        		Console.WriteLine("_ _ _ _ _");
        		break;
        		case 15:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 16:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 17:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 18:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 19:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 20:
        		Console.WriteLine("_ _ _ _");
        		break;
        		case 21:
        		Console.WriteLine("_ _ _ _");
        		break;
        		case 22:
        		Console.WriteLine("_ _ _ _ _");
        		break;
        		case 23:
        		Console.WriteLine("_ _ _ _ _ _ _");
        		break;
        		case 24:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 25:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 26:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 27:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 28:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 29:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        		case 30:
        		Console.WriteLine("_ _ _ _");
        		break;
        		case 31:
        		Console.WriteLine("_ _ _ _ _ _ _");
        		break;
        		case 32:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 33:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 34:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 35:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 36:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 37:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
        		break;
        		case 38:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 39:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 40:
        		Console.WriteLine("_ _ _ _ _ _ _ _ _");
        		break;
        		case 41:
        		Console.WriteLine("_ _ _ _ _");
        		break;
        		case 42:
        		Console.WriteLine("_ _ _ _");
        		break;
        		case 43:
        		Console.WriteLine("_ _ _ _ _ _");
        		break;
        		case 44:
        		Console.WriteLine("_ _ _ _ _ _ _ _");
        		break;
        	}
        	Console.WriteLine("");
        	int x=5;
        	Console.WriteLine("Your lifes: {0}",x);
        	string y;
        	Console.WriteLine("");
        	y=Console.ReadLine();
        	Console.WriteLine("");
        	if (y==list[a])
        	{
        		Console.WriteLine("Ecxellent, you win the game!");
        		Console.WriteLine("");
        		Console.WriteLine("Write 'yes' to another game, or press ENTER  to end the game.");
        		f=Console.ReadLine();
        		Console.Clear();
        	
        	}
        	else 
        	{
        		Console.WriteLine("You missed, try one more time!");
        		x=x-1;
        		Console.WriteLine("Your lifes: {0}",x);
        
        	string c;	
        	Console.WriteLine("");
        	c=Console.ReadLine();
        	Console.WriteLine("");
        	if (c==list[a])
        	{
        		Console.WriteLine("Ecxellent, you win the game!");
        		Console.WriteLine("");
        		Console.WriteLine("Write 'yes' to another game, or press ENTER to end the game.");
        		f=Console.ReadLine();
        		Console.Clear();
        	}
        
        	else 
        	{
        		Console.WriteLine("You missed again, try harder!");
        		x=x-1;
        		Console.WriteLine("Your lifes: {0}",x);
        	
        	string b;	
        	Console.WriteLine("");
        	b=Console.ReadLine();
        	Console.WriteLine("");
        	if (b==list[a])
        	{
        		Console.WriteLine("Ecxellent, you win the game!");
        		Console.WriteLine(" ");
        		Console.WriteLine("Write 'yes' to another game, or press ENTER to end the game.");
        		f=Console.ReadLine();
        		Console.Clear();
        	}
        	
        	else 
        	{
        		Console.WriteLine("You missed the third time, but don't give up!");
        		x=x-1;
        		Console.WriteLine("Your lifes: {0}",x);
        	
        	string d;	
        	Console.WriteLine("");
        	d=Console.ReadLine();
        	Console.WriteLine("");
        	if (d==list[a])
        	{
        		Console.WriteLine("Ecxellent, you win the game!");
        		Console.WriteLine(" ");
        		Console.WriteLine("Write 'yes' to another game, or press ENTER to end the game.");
        		f=Console.ReadLine();
        		Console.Clear();
        	}
        	
        	else 
        	{
        		Console.WriteLine("Another miss, try your LAST CHANSE!");
        		x=x-1;
        		Console.WriteLine("Your lifes: {0}",x);
        		Console.WriteLine("");
        	
        	string e;	
        	Console.WriteLine("");
        	e=Console.ReadLine();
        	Console.WriteLine("");
        	if (e==list[a])
        	{
        		Console.WriteLine("Ecxellent, you win the game!");
        		Console.WriteLine(" ");
        		Console.WriteLine("Write 'yes' to another game, or press random mark to end game.");
        		f=Console.ReadLine();
        		Console.Clear();
        	}
        	
        	else 
        	{
        		Console.WriteLine("You didn't make it, game over :(");
        		Console.WriteLine("");
        	Console.WriteLine("Write 'yes' to another game, or press random mark to end game.");
        	
        	f=Console.ReadLine();
        	Console.Clear();
        	
       
        
        
        	}	
        	}
        	}
        	}
        	}
        	
        	
        
        
        	
	
        
        }
        while (f=="yes");
    }
}
}