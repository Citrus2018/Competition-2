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
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.net");
        openWith.Add("png", "paint.net");
        openWith.Add("xcf", "gimp.exe");
        openWith.Add("rtf", "wordpad.exe");
        openWith.Add("exe", "destiny");

        string answer;
        answer = openWith.ContainsKey(file) ? openWith[file] : null;


        Console.WriteLine("Ваш файл " + answer +" открывается с расширением: "+ file);
        Console.ReadKey();
    }
}
