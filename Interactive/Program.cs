// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

string choice = "";

Console.WriteLine("Hello, World!");
Console.WriteLine("It's time for some tough choices. Choose wisely.");
Console.WriteLine();
Console.WriteLine("Is Coke better than Pepsi?"); //skriv ut meddelanden
Console.WriteLine("Yes[Y] or No[N]?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "y")
{
Console.WriteLine("Great choice! You're officially not a degenerate! Hope you enjoy your awesome drink! :D");
Console.WriteLine("Press ENTER to leave with your awesome opinions!");
}
else if (choice == "n")
{
Console.WriteLine("Oh, no....");
Console.WriteLine("You messed up big time.");
Console.WriteLine("You have one chance to make up for this. Choose the wrong alternative and you are officially smooth-brained.");
Console.WriteLine("Who....is....the....chosen....one?");
Console.WriteLine("(by firstname please)");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "anakin")
{
Console.WriteLine("Thank goodness. You almost had me scared there for a second.");
Console.WriteLine("You can leave now. Press ENTER and go please.");
Console.WriteLine("Just dissappear now.");
}
else if (choice == "luke")
{
Console.WriteLine("An OG trilogy enjoyer I see.");
Console.WriteLine("You're valid. But not more than that. So dissappear now.");
Console.WriteLine("Press ENTER and kapoof.");
}
else
{
Console.WriteLine("You must be the loneliest soul in the galaxy....");
Console.WriteLine("Shame. On. You.");
Console.WriteLine("Press ENTER and get out of my sight now you gremlin.");
}
}
else
{
Console.WriteLine("Wow. Can't even follow simple instructions I see.");
Console.WriteLine("I literally gave you two choices and you still messed up.");
Console.WriteLine("You must be special or something.");
Console.WriteLine("Press the big button usually referred to as ENTER on your keyboard now so I don't have to stare at you for any longer.");
}



Console.ReadLine();