// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, GitHub!");

Console.WriteLine("What would you like to browse? \n\nA. Buzzfeed Quiz \nB. ASCII Cats \nC. Homemade Cookie Recipes \n");
string choice = Console.ReadLine().ToUpper();
switch (choice)
{
    case "A":
        Console.WriteLine();
        Buzzfeed();
        break;
    
    case "B":
        Console.WriteLine();
        Cats();
        break;

    case "C":
        Console.WriteLine();
        Cookies();
        break;

    default:
        Console.WriteLine("Something went wrong! Try again :(");
        break;
}

static void Buzzfeed()
{
    throw new NotImplementedException();
}

static void Cats()
{
    throw new NotImplementedException();
}

static void Cookies()
{
    throw new NotImplementedException();
}