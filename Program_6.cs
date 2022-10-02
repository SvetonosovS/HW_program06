Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber%2 ==0)
{
    Console.WriteLine(userNumber + " -> да(четное)");
}
 else
{
    Console.WriteLine(userNumber + " -> нет(нечетное)");
}