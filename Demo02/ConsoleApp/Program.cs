using MyLibrary;
using System;

Employec Maria = new Secretary();
Maria.Name = "Maria";
Employec Pedro = new Manager();
Pedro.Name = "Pedro";
Employec Miguel = new Developer();
Console.WriteLine($"Dias: {Miguel.GetPaymentDays()}");

WriteEmployecInfo(Maria);
WriteEmployecInfo(Pedro);
WriteEmployecInfo(Miguel);

void WriteEmployecInfo(Employec employec)
{
    Console.WriteLine($"{employec.Name}: {employec.CalculateMonthlyPaymode()}");
    Console.WriteLine($"Days: {employec.GetPaymentDays()}");
}
