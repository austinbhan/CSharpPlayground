// See https://aka.ms/new-console-template for more information

Soup current = Soup.Potato;


while(true)
{
string userInput = Console.ReadLine();


if (userInput == "Chicken")
{
    current = Soup.Chicken;
    Console.WriteLine(current);

}
    if (userInput == "Potato")
    {

    current = Soup.Potato;
    Console.WriteLine(current);
    }
    if (userInput == "Banana")
    current = Soup.Banana;
    Console.WriteLine(current);

}


enum Soup { Potato, Chicken, Banana } 

