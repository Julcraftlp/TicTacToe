using System;
using System.Text;
using System.Threading;
//Line 244 weitercoden
//überprüfung wíns
//Win Screen Einfügen
//Start Screen Einfügen

class TicTacToe
{

    public short[] field = new short[9];
    public void setup()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine("╔═╦═╦═╗\n║ ║ ║ ║\n╠═╬═╬═╣\n║ ║ ║ ║\n╠═╬═╬═╣\n║ ║ ║ ║\n╚═╩═╩═╝");

    }
    public void draw()
    {
        Console.SetCursorPosition(1,1);
        switch (field[0]) {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(3, 1);
        switch (field[1])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(5, 1);
        switch (field[2])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(1, 3);
        switch (field[3])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(3, 3);
        switch (field[4])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(5, 3);
        switch (field[5])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(1, 5);
        switch (field[6])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(3, 5);
        switch (field[7])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.SetCursorPosition(5, 5);
        switch (field[8])
        {
            case 0:
                break;
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;Console.Write("╳");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;Console.Write("O");
                break;
        }
        Console.ResetColor();

    }
    public bool turnx()
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.NumPad7:
                if (field[0] == 0)
                {
                    field[0] = 1;
                    return true;
                }
                else
                    return false;
            case ConsoleKey.NumPad8:
                if (field[1] == 0)
                {
                    field[1] = 1;
                    return true;
                }
                else
                    return false;

            case ConsoleKey.NumPad9:

                if (field[2] == 0)
                {
                    field[2] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad4:
                if (field[3] == 0)
                {
                    field[3] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad5:
                if (field[4] == 0)
                {
                    field[4] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad6:
                if (field[5] == 0)
                {
                    field[5] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad1:
                if (field[6] == 0)
                {
                    field[6] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad2:
                if (field[7] == 0)
                {
                    field[7] = 1;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad3:
                if (field[8] == 0)
                {
                    field[8] = 1;
                    return true;
                }else
                    return false;

            default:
                return false;
        }
    }
    public bool turno()
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.NumPad7:
                if (field[0] == 0)
                {
                    field[0] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad8:
                if (field[1] == 0)
                {
                    field[1] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad9:

                if (field[2] == 0)
                {
                    field[2] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad4:
                if (field[3] == 0)
                {
                    field[3] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad5:
                if (field[4] == 0)
                {
                    field[4] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad6:
                if (field[5] == 0)
                {
                    field[5] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad1:
                if (field[6] == 0)
                {
                    field[6] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad2:
                if (field[7] == 0)
                {
                    field[7] = 2;
                    return true;
                }else
                    return false;

            case ConsoleKey.NumPad3:
                if (field[8] == 0)
                {
                    field[8] = 2;
                    return true;
                }else
                    return false;

            default:
                return false;
        }

    }
    public short proof()
    {
        if (field[0] == field[1] && field[1] == field[2] && field[2] == 1)
            return 1;
        if (field[3] == field[4] && field[4] == field[5] && field[5] == 1)
            return 1;
        if (field[6] == field[7] && field[7] == field[8] && field[8] == 1)
            return 1;
        if (field[0] == field[3] && field[3] == field[6] && field[6] == 1)
            return 1;
        if (field[1] == field[4] && field[4] == field[7] && field[7] == 1)
            return 1;
        if (field[2] == field[5] && field[5] == field[8] && field[8] == 1)
            return 1;
        if (field[0] == field[4] && field[4] == field[8] && field[8] == 1)
            return 1;
        if (field[2] == field[4] && field[4] == field[6] && field[6] == 1)
            return 1;
        if (field[0] == field[1] && field[1] == field[2] && field[2] == 2)
            return 2;
        if (field[3] == field[4] && field[4] == field[5] && field[5] == 2)
            return 2;
        if (field[6] == field[7] && field[7] == field[8] && field[8] == 2)
            return 2;
        if (field[0] == field[3] && field[3] == field[6] && field[6] == 2)
            return 2;
        if (field[1] == field[4] && field[4] == field[7] && field[7] == 2)
            return 2;
        if (field[2] == field[5] && field[5] == field[8] && field[8] == 2)
            return 2;
        if (field[0] == field[4] && field[4] == field[8] && field[8] == 2)
            return 2;
        if (field[2] == field[4] && field[4] == field[6] && field[6] == 2)
            return 2;
        return 0;

    }
}

public class Program
{

    public static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
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
                default:
                    break;
            }
        }
    winx:
        Console.Clear();
        Console.WriteLine("Win für x");
        goto end;
    wino:
        Console.Clear();
        Console.WriteLine("Win für o");
    end:
        Console.WriteLine("V1.0.0");
    }
}




