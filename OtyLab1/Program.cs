using OtyLab1;

internal class Program
{
    static void Main(string[] args)
    {
        int countMove;
        Player2 player2 = new Player2();
        Game game = new Game();
        (int, bool) changeMade;
        string? flag = "d";

        Console.Write("Введите кол-во ходов: ");
        countMove = Convert.ToInt32(Console.ReadLine());
        player2.SequenceOfMoves(countMove);
        player2.OutputMoves();
        Console.WriteLine();

        Console.WriteLine("Сгенерирована последовательность ходов. Для внесения изменений введите \"1\", " +
            "для продолжения введите любой другой символ");
       
        if (Console.ReadLine() == "1")
        {
            while (flag != "f")
            {
                Console.WriteLine("Введите через Enter номер хода и желаемое значение(true/false): ");
                changeMade = (Convert.ToInt32(Console.ReadLine()), Convert.ToBoolean(Console.ReadLine()));
                player2.ChangeSequence(changeMade);
                player2.OutputMoves();
                Console.WriteLine("Если вы внесли все необходимые изменения, нажмите \"f\"");
                flag = Console.ReadLine();
            }
        }

        game.GameProcess(player2.GetMove());

    }
}
