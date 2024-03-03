using System;


/*For this assignment, write a C# program that has several simple functions:

DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.*/

class Program
{
    static string uName = "John Doe";
    static float uNumber = 0;
    static void DisplayWelcome(string msg="Welcome to the Program!"){
        Console.WriteLine(msg);
    }
    static void PromptUserName(string msg="Please enter your name: "){
        Console.Write(msg);
        uName=Console.ReadLine();
    }
    static void PromptUserNumber(string msg="Please enter your favorite number: ")
    {
        Console.Write(msg);
        uNumber = float.Parse(Console.ReadLine());
    }
    static float SquareNumber(float num){
        return num*num;
    }
    static void DisplayResult(){
        Console.WriteLine($"Hello there! {uName}, the square of your number is: {SquareNumber(uNumber)}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        DisplayResult();
    }
}