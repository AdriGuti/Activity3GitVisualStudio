﻿internal class Program
{
    private static void Main(string[] args)
    {
        //prova de push
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Geography();
                    break;

                /* case ConsoleKey.D2:
                     History();
                     break;

                 case ConsoleKey.D3:
                     Science();
                     break;*/

                case ConsoleKey.D0:
                    MsgNextScreen("Press any key to exit");
                    break;

                default:
                    MsgNextScreen("Error. Prem una tecla per a tornar al menu... ");
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void ShowOptions()
    {
        Console.WriteLine("1- Geography");
        Console.WriteLine("2- History");
        Console.WriteLine("3- Science");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    public static void Geography()
    {
        int QuestionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        QuestionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (QuestionNum == 1)
            {
                Console.WriteLine("Quina es la capital d'Estats Units");
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }
    public static void Geography()
    {
        int QuestionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        QuestionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (QuestionNum == 1)
            {
                Console.WriteLine("Quina es la capital d'Estats Units");
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }
}