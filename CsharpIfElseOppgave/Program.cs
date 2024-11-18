// See https://aka.ms/new-console-template for more information
int num1 = 5;
int num2 = 6;
bool equal = false;

 void FalseOrNot()
{
    if (num1 == num2)
    {
        equal = true;
        Console.WriteLine("The numbers match! 5/5");
    }
    else
    {
        equal = false;
        Console.WriteLine("The numbers DON'T match! 5/6");
    }

}

var userInput = Console.ReadLine();

void MakeFalseOrTrue()
{
    if (userInput == "False")
    {
        num2 = 6;
    }
    else if (userInput == "True")
    {
        num2 = 5;
    }
    FalseOrNot();
}
MakeFalseOrTrue();
