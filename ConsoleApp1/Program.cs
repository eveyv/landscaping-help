// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

bool isValid =  false;
bool compOutput = false;

Console.WriteLine("Welcome, worker!!");


while (!isValid)
{
    Console.WriteLine("Do you want an output file? Enter Y/N");
    string userInput = Console.ReadLine();

    switch (userInput.ToLower())
    {
        case "y":
            string outfile = "/C/user/me/desktop/file.txt";
            isValid = true;
            break;
        case "n":
            isValid = true;
            break;
        default:
            Console.WriteLine("Invalid entry...");
            break;
    }

}

bool isValid1 = false;

while (!isValid1)
{
    Console.Write("Please enter the material type (mulch, dirt, or gravel): ");
    string userInput1 = Console.ReadLine();

    switch (userInput1.ToLower())
    {
        case "mulch":
            string materialType = userInput1.ToUpper();
            Console.WriteLine($"You selected: {materialType}");
            isValid1 = true;
            break;
        case "dirt":
            materialType = userInput1.ToUpper();
            Console.WriteLine($"You selected: {materialType}");
            isValid1 = true;
            break;
        case "gravel":
            materialType = userInput1.ToUpper();
            Console.WriteLine($"You selected: {materialType}");
            isValid1 = true;
            break;
        default:
            Console.WriteLine("Invalid material type.");
            break;
    }
}

Console.WriteLine("Enter Length: ");
int height;
    while (!int.TryParse(Console.ReadLine(), out height ) ) Console.WriteLine("Invalid. Enter Integer."); 

Console.WriteLine("Enter Width: ");
int width;
    while (!int.TryParse(Console.ReadLine(), out width)) Console.WriteLine("Ivalid. Enter Integer.");

Console.WriteLine("Enter Depth: ");
int depth;
    while (!int.TryParse(Console.ReadLine(), out depth)) Console.WriteLine("Ivalid. Enter Integer.");

// calculation for volume here -- expand logic to account for rectangles, triangles and circles.


Console.WriteLine("Press any key to exit...");
Console.ReadKey();
