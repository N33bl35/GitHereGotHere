// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("To exit the game, type exit.");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Do you like music?");
Console.ForegroundColor = ConsoleColor.DarkGreen;
var shitIMadeUp = "Well...";
var userInput = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("I expected as much. " + shitIMadeUp);
var gameOver = false;
while(!gameOver)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("What genre?");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    userInput = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("");

    switch (userInput.ToLower())
    {
        case "exit":
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You should really expand your musical taste...");
            gameOver = true;
            break;
        case "jazz":
            Console.WriteLine("You're definitely an alcoholic.");
            break;
        case "rock":
            Console.WriteLine("And I bet Hybrid Theory is your favorite album...basic.");
            break;
        case "metal":
            Console.WriteLine("And you're running this program? Seems pretty Techno to me.");
            break;
        case "heavy metal":
            Console.WriteLine("And you're running this program? Seems pretty Techno to me.");
            break;
        case "country":
            Console.WriteLine("Just leave.");
            break;
        case "pop":
            Console.WriteLine("You have the worst taste in music ever, congratulations.");
            break;
        case "rap":
            Console.WriteLine("I should bust a cap in that ass rn, frfr, no cap.");
            break;
        case "classical":
            Console.WriteLine("Seriously, you should go to AA meetings.");
            break;
        case "edm":
            Console.WriteLine("Where's Molly?");
            break;
        case "electronic":
            Console.WriteLine("You've never even been to a rave, don't pretend.");
            break;
        case "alternative":
            Console.WriteLine("Alternatively, you could listen to literally anything else.");
            break;
        case "hip-hop":
            Console.WriteLine("Those sneakers don't change the fact that you're a piece of trash.");
            break;
        case "djent":
            Console.WriteLine("That's just music written by artists who were too weird to become popular in high school.");
            break;
        case "prog rock":
            Console.WriteLine("This is what happens when you start prescribing all the kids adderall.");
            break;
        case "dubstep":
            Console.WriteLine("Great...you think the way floppy disks sounded is cool...");
            break;
        case "drum and bass":
            Console.WriteLine("The only thing you did right in your life was percussion.");
            break;
        case "reggae":
            Console.WriteLine("If you haven't made it in your career by now, just smoke another one.");
            break;
        case "r&b":
            Console.WriteLine("You have to rely on music to get your partner in the mood? Pathetic.");
            break;
        default: 
            Console.WriteLine("If you ever thought you were cool, abandon all hope.");
            break;
    }
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Press enter/return key to exit.");
Console.ReadLine(); 