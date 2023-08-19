using BmiConsoleCalculator;

bool run = true;
int weight;
int height;
do
{
    try
    {
        Console.WriteLine("Enter the height in inches");
        height = Convert.ToInt32(Console.ReadLine());
    }
    catch {
        Console.WriteLine("An error has occured!");
    }
    finally
    {
        Console.WriteLine("Please enter height in inches as a whole number!");
        height = Convert.ToInt32(Console.ReadLine());
    }
    try
    {
        Console.WriteLine("Enter the weight in pounds");
        weight = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Something went wrong!");
    }
    finally
    {
        Console.WriteLine("Enter the weight in pounds");
        weight = Convert.ToInt32(Console.ReadLine());
    }
    var Person1 = new Person(height, weight);
    var bmi = Person1.getBMI(height, weight);
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