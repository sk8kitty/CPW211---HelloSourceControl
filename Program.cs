Console.WriteLine("Hello, GitHub users!");
MainMenu();

static void MainMenu()
{
    string title = @"
               .__                                      
      _____ _____  |__| ____     _____   ____   ____  __ __ 
     /     \\__  \ |  |/    \   /     \_/ __ \ /    \|  |  \
    |  Y Y  \/ __ \|  |   |  \ |  Y Y  \  ___/|   |  \  |  /
    |__|_|  (____  /__|___|  / |__|_|  /\___  >___|  /____/ 
          \/     \/        \/        \/     \/     \/       
                                                    ";
    Console.WriteLine(title);
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
    Console.WriteLine();
    MainMenu();
}

static void Buzzfeed()
{
    string title = @"
    __________                        _____                 .___
    \______   \__ ___________________/ ____\____   ____   __| _/
     |    |  _/  |  \___   /\___   /\   __\/ __ \_/ __ \ / __ | 
     |    |   \  |  //    /  /    /  |  | \  ___/\  ___// /_/ | 
     |______  /____//_____ \/_____ \ |__|  \___  >\___  >____ | 
            \/            \/      \/           \/     \/     \/ 
                                                            ";
    Console.WriteLine(title);

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
    string title = @"
    _________ .__                    _________ .__    .__         _________                __   .__               
    \_   ___ \|  |__   ____   ____   \_   ___ \|  |__ |__|_____   \_   ___ \  ____   ____ |  | _|__| ____   ______
    /    \  \/|  |  \ /  _ \_/ ___\  /    \  \/|  |  \|  \____ \  /    \  \/ /  _ \ /  _ \|  |/ /  |/ __ \ /  ___/
    \     \___|   Y  (  <_> )  \___  \     \___|   Y  \  |  |_> > \     \___(  <_> |  <_> )    <|  \  ___/ \___ \ 
     \______  /___|  /\____/ \___  >  \______  /___|  /__|   __/   \______  /\____/ \____/|__|_ \__|\___  >____  >
            \/     \/            \/          \/     \/   |__|             \/                   \/       \/     \/ 
                                                                     ";
    Console.WriteLine(title);

    Console.WriteLine("A classic recipe from 'Better Homes and Cooking'");
    Console.WriteLine("Makes about 40 1-tbsp cookies");
    Console.WriteLine();
    Console.WriteLine("Ingredient List:");
    Console.WriteLine("1 stick (= 1 cup) of Crisco shortening");
    Console.WriteLine("1 cup packed brown sugar");
    Console.WriteLine("1/2 cup regular cane sugar");
    Console.WriteLine("1/2 tsp baking soda");
    Console.WriteLine("1 tsp vanilla extract");
    Console.WriteLine("2 eggs");
    Console.WriteLine("2 1/2 cups all purpose flour");
    Console.WriteLine("12 oz unsweetened chocolate chips");
    Console.WriteLine();
    Console.WriteLine("Instructions:");
    Console.WriteLine("Cream shortening and sugars until extremely smooth, no chunks");
    Console.WriteLine("Add baking soda, eggs, and vanilla until well combined");
    Console.WriteLine("Add flour by the scoop, stirring each scoop in");
    Console.WriteLine("Add chocolate chips and fold dough over until well combined");
    Console.WriteLine();
    Console.WriteLine("Roll dough into balls of desired size and place on baking sheet");
    Console.WriteLine("10 cookies per sheet reccomended; press dough balls into even thickness for best results");
    Console.WriteLine("Chill in fridge for 1 hour");
    Console.WriteLine("Bake at 375F for 8-10 minutes (dependent on baking sheet size)");
    Console.WriteLine();
    Console.WriteLine();
    MainMenu();
}