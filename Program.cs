//lerissa lazar
//10-20-22
//restraunt picker 
//the user will choose a category for the restraunts, and it will randomize 10 different restraunts.
//Peer Reviewed By: Kenneth Fujimura
//I ran through the code and program and couldn't really find anything wrong. Everything works as it should. The code is clean, well organized, and very easy to follow. You've got everything needed for the A grade I believe. I also liked that you used the .Length for the randomization, which will make your program more robust and easy to add new restaurants if you like in the future. So great work all around! The only things I think are worth mentioning as small critiques:
//- I would get into the habit of putting in more comments in your code. While our programs are still simple like this, it's not that big of a deal. But as we develop more complicated programs, it's going to be a good idea. Not just so other people can more easily read your code and follow your train of thought on how it's structured. But also so that while you're writing it, you yourself can better keep track of what everything does.
//- In your instructions to the user, you say "...or choose random for any!" which I assume is an artifact of a possible build where you were going to let the player get a restaurant from any of the categories all at once. And as far as I can tell, that doesn't work/isn't built into your code. So I would maybe append or delete that to make things more straight forward.
//- If you have time, I would tinker with your text output in the console so that it's a little more legible. Including some linebreaks and other formatting generally helps users read the console outputs quicker. But that's not actually necessary for this program and more of a flourish than anything.
//- Double check with Ken to see if your title formatting is ok. I think it should be? But I haven't seen anyone else use periods and lowercase letters in the Program title, so I'm not 100% positive it'll work. And I know Ken is going to be extra mean if we botch up the program titles for this. (A straight 0 on the assignment).

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

