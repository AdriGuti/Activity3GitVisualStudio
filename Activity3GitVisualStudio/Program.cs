internal class Program
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
    public static void History()
    {
        int QuestionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        QuestionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            switch (QuestionNum)
            {
                case 1: Console.WriteLine("Quan va ser la guerra civil española?" +
                                           "a.1916-1919" +
                                           "b.1926-1929" +
                                           "c.1936-1939" +
                                           "d.1946-1949");
                    if (Console.ReadKey().KeyChar == 'c')
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                case 2: Console.WriteLine("Quan es descobreix America?" +
                                           "a.1423" +
                                           "b.1926" +
                                           "c.1492" +
                                           "d.1203");
                    if (Console.ReadKey().KeyChar == 'c')
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                  case 3:
                    Console.WriteLine("Qui descobreix la gravetat?" +
                                           "a.Albert Einstein" +
                                           "b.Arquimedes" +
                                           "c.Newton" +
                                           "d.Bohr");
                    if (Console.ReadKey().KeyChar == 'c')
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
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