//lerissa lazar
//10-20-22
//restraunt picker 
//the user will choose a category for the restraunts, and it will randomize 10 different restraunts.

Console.Clear();

Random rnd = new Random();
string[] breakfast = {"IHOP", "Perkos", "Dennys", "Dunkin Donuts", "Huckleberrys", "Black Bear Diner", "Omelet House",
                    "Waffle House", "Bryn Mawr Breakfast Club", "Flying Biscuit Cafe"};
string[] lunch = {"Mountain Mikes", "Chipotle", "Commonwealth", "Mcdonalds", "In-N-Out", "Burger King", "Jack N the Box",
                    "Panera bread", "Subway", "Chick Fil a"};
string[] dinner = {"WildFire", "Redwood Cafe", "Raw Garden", "Longhorn Steakhouse", "Skewers Kabob House", "Ramen 101",
                    "Memos Cocina", "Texas RoadHouse", "Outback Steakhouse", "BJs"};

bool run = true;
while (run)
{
    int breakfastIndex = rnd.Next(breakfast.Length);
    int lunchIndex = rnd.Next(lunch.Length);
    int dinnerIndex = rnd.Next(dinner.Length);

    string? option;

    Console.WriteLine("Confused on what to eat? Choose what category you're looking for, or choose random for any!\nBreakfast\nLunch\nDinner\n");

    bool invalid = true;
    while (invalid)
    {
        option = Console.ReadLine().ToLower();
        invalid = false;
        if (option == "breakfast")
        {
            Console.WriteLine("You got {0}", breakfast[breakfastIndex]);
        }
        else if (option == "lunch")
        {
            Console.WriteLine("You got {0}", lunch[lunchIndex]);
        }
        else if (option == "dinner")
        {
            Console.WriteLine("You got {0}", dinner[dinnerIndex]);
        }
        else
        {
            Console.WriteLine("Invalid choice, Enter : breakfast, lunch or dinner");
            invalid = true;
        }
    }

    Console.WriteLine("Would you like to try another option? Yes or no?");

    string playAgain;
    bool validInput = false;
    while (!validInput)
    {
        playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")
        {
            validInput = true;
        }
        else if (playAgain == "no")
        {
            validInput = true;
            run = false;
            Console.WriteLine("Hope you found somewhere to eat!");
        }
        else
        {
            Console.WriteLine("Invalid repsonse, answer yes or no");
        }
    }
}

