using System;

public class Program
{
    static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //your code goes here
        foreach (char letter in alphabet){
            string letterCapitalCase = letter.ToString().ToUpper(); // Convert char to string first and then we can use ToUpper method 
            Console.WriteLine(letterCapitalCase);
        }
    }
}