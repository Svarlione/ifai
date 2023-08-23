Console.WriteLine("Labas, iveskite skaiciu,aciu");
string userInput = Console.ReadLine();
int userInputInteger = Convert.ToInt32(userInput);
if (userInputInteger > 100)
 Console.WriteLine("Jusu skaicius yra didesnis nei 100");
    else if (userInputInteger == 100)
        Console.WriteLine("Skaicius yra lygus 100");
    else
        Console.WriteLine("skaicius yra mazesmis nei 100");
