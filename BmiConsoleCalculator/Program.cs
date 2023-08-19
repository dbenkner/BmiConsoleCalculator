using BmiConsoleCalculator;
using System;

bool run = true;
double weight;
double  height;
bool isEnglish;
string engOrMet;
do
{
    height = getHeight();
    bool numValid = validChecker(height);
    if (numValid == false )
    {
        height = getHeight();
    }
    weight = getWeight();
    numValid = validChecker(weight);
    if (numValid == false )
    {
        weight = getWeight();
    }
    Console.WriteLine("Please enter E for English or M for metric");
    try
    {
        engOrMet = Console.ReadLine();
    }
    catch
    {
        Console.WriteLine("Please enter E for English or M for metric");
        engOrMet = Console.ReadLine();
    }
    if (engOrMet != "E" || engOrMet != "e" || engOrMet != "M" or || engOrMet = "m") {
        Console.WriteLine("Please enter an E for english or M for metric!");
        try
        {
            engOrMet = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Please enter E for English or M for metric");
            engOrMet = Console.ReadLine();
        }
    }
    isEnglish = (engOrMet == "E" || engOrMet == "e") ? true : false;
    var Person1 = new Person(height, weight);
    double bmi = Person1.getBMI(height, weight, isEnglish);
    Console.WriteLine($"The height is {Person1.height} and the weight is {Person1.weight} and the bmi {bmi}");
    run = Quit();
} while (run == true);
bool Quit()
{
    // function asking of user wants to quit the program
    string quit;
    var dontQuit = true;
    Console.Write("Do you want to quit Y/N");
    quit = Console.ReadLine();
    if (quit == "Y" || quit == "y")
    {
        dontQuit = false;
    }
    else if (quit != "Y" && quit != "y" && quit != "N" && quit != "n")
    {
        Console.Write("Please enter a Y or N");
        dontQuit = Quit();
    }
    return dontQuit; 
}
double getHeight()
{
    Console.WriteLine("Enter the height");
    try
    {
        height = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please enter height as a number!");
        height = Convert.ToInt32(Console.ReadLine());
    }
    return height;
}
double getWeight()
{
    Console.WriteLine("Enter the weight");
    try
    {
        weight = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Enter the weight as a number");
        weight = Convert.ToInt32(Console.ReadLine());
    }
    return weight;
}
bool checkZero(double num)
{
    bool zeroCheck = false;
    if (num == 0)
    {
        zeroCheck = true;
    }
    return zeroCheck;
}
bool validChecker(double num)
{
    bool isZero = checkZero(num);
    bool isValid = true;
    if (isZero == true)
    {
        isValid = false;
        Console.WriteLine("Please enter a none zero number!");
        return isValid;
    }
    return isValid;
}


