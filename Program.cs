Console.WriteLine("Hello, GitHub users!");
MainMenu();

static void MainMenu()
{
    Console.WriteLine("What would you like to browse?");
    Console.WriteLine("\nA. ASCII Cats \nB. Buzzfeed Quiz \nC. Homemade Cookie Recipe \n");
    string choice = Console.ReadLine().ToUpper();

    switch (choice)
    {
        case "A":
            Console.WriteLine();
            Cats();
            break;

        case "B":
            Console.WriteLine();
            Buzzfeed();
            break;

        case "C":
            Console.WriteLine();
            Cookies();
            break;

        default:
            Console.WriteLine("Something went wrong! Try again :(");
            break;
    }
}


static void Cats()
{
    string title = @"
       _____    __________________ .___.___      _________     _________________________
      /  _  \  /   _____/\_   ___ \|   |   |     \_   ___ \   /  _  \__    ___/   _____/
     /  /_\  \ \_____  \ /    \  \/|   |   |     /    \  \/  /  /_\  \|    |  \_____  \ 
    /    |    \/        \\     \___|   |   |     \     \____/    |    \    |  /        \
    \____|__  /_______  / \______  /___|___|      \______  /\____|__  /____| /_______  /
            \/        \/         \/                      \/         \/               \/ 
                                                                ";
    Console.WriteLine(title);
    Console.WriteLine();

    string cat1 = @"
               __..--''``---....___   _..._    __
     /// //_.-'    .-/"";  `        ``<._  ``.''_ `. / // /
    ///_.-' _..--.'_    \                    `( ) ) // //
    / (_..-' // (< _     ;_..__               ; `' / ///
     / // // //  `-._,_)' // / ``--...____..-' /// / // 
                                                                 ";

    string cat2 = @"
                   _ |\_
                   \` ..\
              __,.-"" =__Y=
            .""        )
      _    /   ,    \/\_
     ((____|    )_-\ \_-`
     `-----'`-----` `--`
                                                                 ";

    string cat3 = @"
           ,-.       _,---._ __  / \
     /  )    .-'       `./ /   \
    (  (   ,'            `/    /|
     \  `-""             \'\   / |
      `.              ,  \ \ /  |
       /`.          ,'-`----Y   |
      (            ;        |   '
      |  ,-.    ,-'         |  /
      |  | (   |            | /
      )  |  \  `.___________|/
      `--'   `--'
                                                                 ";

    Console.WriteLine(cat1);
    Console.WriteLine(cat2); 
    Console.WriteLine(cat3);
    Console.WriteLine();

    MainMenu();
}

static void Buzzfeed()
{
    Console.WriteLine("( Enter 'Z' to quit to menu )");
    Console.WriteLine("BUZZFEED! This simple question will decide what kind of cake you are. Pick one:");
    Console.WriteLine("A. Cat \nB. Dog \nC. Mouse \nD. Horse");

    string choice = Console.ReadLine().ToUpper();
    switch (choice)
    {
        case "A":
            Console.WriteLine("Vanilla cake. Seemingly bland, but balanced.");
            break;

        case "B":
            Console.WriteLine("Chocolate cake. You can't ever get enough.");
            break;

        case "C":
            Console.WriteLine("Carrot cake. What, how'd you know already?");
            break;

        case "D":
            Console.WriteLine("Strawberry shortcake. I don't know why, I don't make the rules.");
            break;

        case "Z":
            break;

        default:
            Console.WriteLine("Sorry, something went wrong over at Buzzfeed HQ. Try entering A, B, C, or D next time.");
            break;
    }

    Console.WriteLine("( Quiz over! ) \n\n");
    MainMenu();
}

static void Cookies()
{
    throw new NotImplementedException();
}