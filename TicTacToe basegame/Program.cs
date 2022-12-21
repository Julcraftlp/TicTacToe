using System;
using System.Text;
using System.Threading;
using TicTacToe_basegame;

public class Program
{

    public static void Main(string[] args)
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        TicTacToe game = new TicTacToe();
    start:
        for (int i = 0; i < 9; i++)
            game.field[i] = 0;
        switch (game.mainmenu())
        {
            case 1:
            game.setup();
            game.draw();
            while (true)
            {
                while (game.turnx() == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    game.setup();
                    Thread.Sleep(500);
                    Console.ResetColor();
                    game.setup();
                    game.draw();
                }
                game.draw();
                switch (game.proof())
                {
                    case 1:
                        goto winx;
                    case 2:
                        goto wino;
                    case 3:
                        goto patt;
                    default:
                        break;
                }
                while (game.turno() == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    game.setup();
                    Thread.Sleep(500);
                    Console.ResetColor();
                    game.setup();
                    game.draw();
                }
                game.draw();
                switch (game.proof())
                {
                    case 1:
                        goto winx;
                    case 2:
                        goto wino;
                    case 3:
                        goto patt;
                    default:
                        break;
                }
            }//Game Loop
            winx:
                Console.Clear();
                Console.WriteLine("Win für x");
                goto end;
            wino:
                Console.Clear();
                Console.WriteLine("Win für o");
                goto end;
            patt:
                Console.Clear();
                Console.WriteLine("Patt");
                goto end;
            end:
                Console.WriteLine("Game Version:1.2.1");
                Console.WriteLine("Drücke etwas um zum hauptmenü zurückzukehren");
                Console.ReadKey(true);
                goto start;
        }//Game Mainscript
    }
}




