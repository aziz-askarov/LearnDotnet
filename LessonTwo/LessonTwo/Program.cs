var questions = new string[][]
{
    new[] {"1+1","0","3","2","2" },
    new[] {"2+1","5","3","2","3" },
    new[] {"9+1","10","3","2","10" },
    new[] {"4-2","3","2","1","2" }
};

for (int i = 0; i < questions.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{i + 1}. Savol: {questions[i][0]}");
    Console.ForegroundColor = ConsoleColor.White;

    for (int j = 1; j < questions[i].Length - 1; j++)
    {
        Console.WriteLine(questions[i][j]);
    }

    var shart = false;
    var input = "";

    do
    {
        Console.Write("Javob: ");
        input = Console.ReadLine();

        shart = input == questions[i][0] || input == questions[i][1] || input == questions[i][2];

        if (shart)
            Console.WriteLine("Berilgan varianlardan javob bering;");
    }
    while (!shart);


    if (input == questions[i][questions[i].Length - 1])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("To'g'ri");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Noto'g'ri");
    }

    Console.ForegroundColor = ConsoleColor.White;
}