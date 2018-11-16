using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Create a new dictionary of strings, with string keys.
        //
        Dictionary<string, string> openWith =
            new Dictionary<string, string>();

        string file = Console.ReadLine();

        // Add some elements to the dictionary. There are no 
        // duplicate keys, but some of the values are duplicates.
        openWith.Add("notepad.exe", "txt" );
        openWith.Add("paint.net", "bmp");
        openWith.Add("paint.net", "png");
        openWith.Add("gimp.exe", "xcf");
        openWith.Add("wordpad.exe", "rtf");
        
        string answer;
        answer = openWith.ContainsKey(file) ? openWith[file] :  null ; 
        
     
        Console.WriteLine("Ваш файл открывается с расширением:", answer );
    }
}

