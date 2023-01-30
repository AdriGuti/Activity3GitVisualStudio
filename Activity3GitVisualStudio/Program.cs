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

                 case ConsoleKey.D2:
                     History();
                     break;

                /*case ConsoleKey.D3:
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
                case 1: Console.WriteLine("Quan va ser la guerra civil española?\n" +
                                           "a.1916-1919\n" +
                                           "b.1926-1929\n" +
                                           "c.1936-1939\n" +
                                           "d.1946-1949\n");
                    if (Console.ReadLine() == "c")
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                case 2: Console.WriteLine("Quan es descobreix America?\n" +
                                           "a.1423\n" +
                                           "b.1926\n" +
                                           "c.1492\n" +
                                           "d.1203\n");
                    if (Console.ReadLine() == "c")
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                  case 3:
                    Console.WriteLine("Qui descobreix la gravetat?\n" +
                                           "a.Albert Einstein\n" +
                                           "b.Arquimedes\n" +
                                           "c.Newton\n" +
                                           "d.Bohr\n");
                    if (Console.ReadLine() == "c")
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                case 4:
                    Console.WriteLine("Quan apareix l'agricultura?\n" +
                                           "a.Neolític\n" +
                                           "b.Edad mitjana\n" +
                                           "c.Paleolític\n" +
                                           "d.Edad moderna\n");
                    if (Console.ReadLine() == "a")
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                case 5:
                    Console.WriteLine("Quan s'inventa l'escriptura??\n" +
                                           "a.Fa 20 mil anys\n" +
                                           "b.En el IV mileni A.C.\n" +
                                           "c.A l'any 0\n" +
                                           "d.Al 1978\n");
                    if (Console.ReadLine() == "b")
                    {
                        Console.WriteLine("Correcte");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecte");
                    }
                    break;
                default:
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