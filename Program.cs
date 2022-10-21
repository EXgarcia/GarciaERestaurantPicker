//Elizar Garcia
//10-20-22
//Challenge "Restaurant Picker"
//In this project we will be making a list of restaurants for our user

Console.Clear();

bool playAgain = true;
int randoNum = 0;


while(playAgain == true)
{
    Console.WriteLine("Hello! Let's get something to eat. Dont know where to eat? I got you!");
    Console.WriteLine("What are you in the mood for??");

    Console.WriteLine("");
    Console.WriteLine("Here are some options for you to choose:\n(>^-^)> American Food <(^-^<)\n(>^-^)> Asian    Food <(^-^<)\n(>^-^)> Mexican  Food <(^-^<)");
    Console.WriteLine("");
    string foodChoice = Console.ReadLine().ToUpper();
    bool answerNum = Int32.TryParse(foodChoice, out randoNum);

    if(answerNum == true)
    {
        Console.WriteLine("<{*~*}> Invalid Entry <{*~*}>");
    }
    if(foodChoice == "AMERICAN FOOD")
    {   Console.WriteLine("");
        Console.WriteLine("Okay, American Food it is! Here is what I have for you.");
        Console.WriteLine("");

        Random rndNumber = new Random();
        int rndNumber1 = rndNumber.Next(1, 10);

        switch(rndNumber1)
        {
            case 1: Console.WriteLine("Market Tavern");
             break;
            case 2: Console.WriteLine("The Habit");
             break;
            case 3: Console.WriteLine("In N Out Burger");
             break;
            case 4: Console.WriteLine("Midgley's Public House");
            break;
            case 5: Console.WriteLine("Lumberjacks"); 
            break;
            case 6: Console.WriteLine("IHop");
            break;
            case 7: Console.WriteLine("Denny's");
            break;
            case 8: Console.WriteLine("BJ's Restaurant & Brewhouse");
            break;
            case 9: Console.WriteLine("Moo Moo's Burger Barn");
            break;
            case 10: Console.WriteLine("Whirlows");
            break;
        }
        

    }
    
     if(foodChoice == "ASIAN FOOD" )
    {   Console.WriteLine("");
        Console.WriteLine("Asian Food, nice! I know I could always go for some sushi!");
        Console.WriteLine("");

        Random rndNumber = new Random();
        int rndNumber2 = rndNumber.Next(1, 10);

         switch(rndNumber2)
        {
            case 1: Console.WriteLine("Prosperity Szechuan Cuisine");
             break;
            case 2: Console.WriteLine("New Yen Ching Restaurant");
             break;
            case 3: Console.WriteLine("China Palace");
             break;
            case 4: Console.WriteLine("Green Papaya");
            break;
            case 5: Console.WriteLine("GK Mongolian BBQ"); 
            break;
            case 6: Console.WriteLine("Lao, Der");
            break;
            case 7: Console.WriteLine("Sushi Villa Buffet");
            break;
            case 8: Console.WriteLine("Quickly");
            break;
            case 9: Console.WriteLine("Bayon Restaurant");
            break;
            case 10: Console.WriteLine("Shome Japenese Cuisine");
            break;
    }
    

}
if(foodChoice == "MEXICAN FOOD")
{   Console.WriteLine("");
    Console.WriteLine("Mexican Food is always good! I hope you're ready to punish that toilet later!");
    Console.WriteLine("");

     Random rndNumber = new Random();
        int rndNumber3 = rndNumber.Next(1, 10);

         switch(rndNumber3)
        {
            case 1: Console.WriteLine("Taco Bell");
             break;
            case 2: Console.WriteLine("Chapala");
             break;
            case 3: Console.WriteLine("Nene's");
             break;
            case 4: Console.WriteLine("El Pollo Loco");
            break;
            case 5: Console.WriteLine("Casa Flores"); 
            break;
            case 6: Console.WriteLine("El Frutal");
            break;
            case 7: Console.WriteLine("Taco House");
            break;
            case 8: Console.WriteLine("Alberto's Mexican Food");
            break;
            case 9: Console.WriteLine("Rubio's Coastal Grill");
            break;
            case 10: Console.WriteLine("Don Luis");
            break;
    }
    


}
Console.WriteLine("");
Console.WriteLine("Not feeling this option? Press enter to start over and select a different category or pick the same one for a diffent restaurant.");
Console.WriteLine("If you have you found a place to eat and my services are no longer needed type \"Thank You\" to end.");
string gameOver = Console.ReadLine().ToUpper();

if(gameOver == "THANK YOU")
{
    playAgain = false;
}
}