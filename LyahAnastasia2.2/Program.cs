using System;
using System.IO;
using System.Linq;

class Program
{
    static void CompareFiles(string file1, string file2, string outputFile)
    {
        string[] words1 = File.ReadAllText(file1).Split(' ');
        string[] words2 = File.ReadAllText(file2).Split(' ');

        var mismatchedWords = words1.Except(words2).Concat(words2.Except(words1));

        File.WriteAllLines(outputFile, mismatchedWords);
    }

    static void Main(string[] args)
    {
        string file1 = "C:\\Users\\Анастасія\\OneDrive\\Рабочий стол\\F1.txt"; 
        string file2 = "C:\\Users\\Анастасія\\OneDrive\\Рабочий стол\\F2.txt"; 
        string outputFile = "C:\\Users\\Анастасія\\OneDrive\\Рабочий стол\\G.txt"; 

        CompareFiles(file1, file2, outputFile);

        Console.WriteLine("Збiги та вiдмiнностi записано у файлi G.txt");
    }
}
