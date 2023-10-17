using OtyLab1;

internal class Program
{
    static void Main(string[] args)
    {
        int countMove, countGame, lengthGame = 0;
        Player2 player2 = new Player2();
        Game game = new Game();
        string order = "+4-5+5-3";
       
        
     //   (int, bool) changeMade;
  //      string? flag = "d";
        
        Console.Write("Введите кол-во партий: ");
        countGame = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите кол-во ходов: ");
        countMove = Convert.ToInt32(Console.ReadLine());

        bool[] arrMove = new bool[countMove];
        int c = 0;
        for (int i = 0; i < (order.Length-1); i++)
        {
            if(i%2 == 0)
            {
                if (order[i] == '+')
                {
                    for (int j = 0 ; j < Convert.ToInt32(order[i + 1].ToString()); j++, c++)
                        arrMove[c] = true;
                }
                else
                {
                    for (int j = 0; j < Convert.ToInt32(order[i + 1].ToString()); j++, c++)
                        arrMove[c] = false;
                }
            }            
        }
        //  player2.SequenceOfMoves(countMove);
        //    player2.OutputMoves();
        //     Console.WriteLine();

        //Console.WriteLine("Сгенерирована последовательность ходов. Для внесения изменений введите \"1\", " +
        //    "для продолжения введите любой другой символ");

        //if (Console.ReadLine() == "1")
        //{
        //    while (flag != "f")
        //    {
        //        Console.WriteLine("Введите через Enter номер хода и желаемое значение(true/false): ");
        //        changeMade = (Convert.ToInt32(Console.ReadLine()), Convert.ToBoolean(Console.ReadLine()));
        //        player2.ChangeSequence(changeMade);
        //        player2.OutputMoves();
        //        Console.WriteLine("Если вы внесли все необходимые изменения, нажмите \"f\"");
        //        flag = Console.ReadLine();
        //    }
        //}

        //for (int i = 0; i < countGame; i++)
        //{
        //    game.GameProcess(player2.GetMove());
        //    lengthGame += game.lengthGame;
        //}

        for (int i = 0; i < countGame; i++)
        {
            game.GameProcess(arrMove);
            lengthGame += game.lengthGame;
        }

        Console.WriteLine("Победы: " + game.countWin);
        Console.WriteLine("Поражение: " + game.countLose);
        Console.WriteLine("Средняя длина партии: " + (lengthGame/game.countWin));


    }
}
