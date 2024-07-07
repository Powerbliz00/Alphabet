# Uppercase Alphabet

This simple C# program demonstrates how to convert lowercase letters to uppercase using the `ToUpper()` method.

## Code Explanation

The code iterates through the lowercase alphabet and converts each letter to uppercase using the `ToUpper()` method. It then prints the uppercase letters to the console.

```C#
using System;

public class Program
{
    static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //your code goes here
        foreach (char letter in alphabet){
            string letterCapitalCase = letter.ToString().ToUpper(); 
            Console.WriteLine(letterCapitalCase);
        }
    }
}
```

## Running the Program

### Windows

1. **Install .NET SDK:** If you don't have it already, download and install the .NET SDK from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
2. **Compile the code:** Open a command prompt and navigate to the directory containing the C# file (`Program.cs`). Run the following command to compile the code:
   ```bash
   dotnet build
   ```
3. **Run the program:** Execute the following command to run the compiled program:
   ```bash
   dotnet run
   ```

### Linux

1. **Install .NET SDK:**  Install the .NET SDK using your distribution's package manager. For example, on Ubuntu:
   ```bash
   sudo apt update
   sudo apt install dotnet-sdk-6.0
   ```
2. **Compile the code:** Open a terminal and navigate to the directory containing the C# file (`Program.cs`). Run the following command to compile the code:
   ```bash
   dotnet build
   ```
3. **Run the program:** Execute the following command to run the compiled program:
   ```bash
   dotnet run
   ```

## Output

The program will output the uppercase alphabet to the console, one letter per line:

```
A
B
C
...
Z
```

This repository serves as a basic example of string manipulation in C# and demonstrates the use of the `ToUpper()` method
and the need of `Type conversion from char type from string type, using ToString() method`. 