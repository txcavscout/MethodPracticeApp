using MethodPractice;


string yourFirstName = MyConsoleMessages.GetFirstName();
string yourLastName = MyConsoleMessages.GetLastName();

double firstNumber = MyConsoleMessages.GetX();
double secondNumber = MyConsoleMessages.GetY();

Console.WriteLine($"\nHello {yourFirstName} {yourLastName}, how are you today?");

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");