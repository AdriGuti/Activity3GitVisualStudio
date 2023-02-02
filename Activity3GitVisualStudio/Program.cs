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
            //This is a menu that asks you to input a number to choose the topic of the questions
            switch (tecla.Key)
            {
                 case ConsoleKey.D1:
                      Geography();
                      break;


                 case ConsoleKey.D2:
                     History();
                     break;
                 case ConsoleKey.D3:
                     Science();
                     break;
                
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
        //If we didn't had this you could never see what topis are there and which one choose.
        Console.WriteLine("Choose one topic");

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
        char answer;
        int questionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        questionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            //All of this is the code to make the trivia work, here if you answer the num 1-5 you get a question.
            if (questionNum == 1)
            {
                Console.WriteLine("Quina es la capital d'Espanya");
                Console.WriteLine("a. Madrid");
                Console.WriteLine("b. Oslo");
                Console.WriteLine("c. Barcelona");
                Console.WriteLine("d. Berlin");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'a') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 2)
            {
                Console.WriteLine("Quantes comunitats autonomes te Espanya?");
                Console.WriteLine("a. 15");
                Console.WriteLine("b. 17");
                Console.WriteLine("c. 19");
                Console.WriteLine("d. 20");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'b') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 3)
            {
                Console.WriteLine("Quin és el riu més llarg del mon?");
                Console.WriteLine("a. Nil");
                Console.WriteLine("b. Ebre");
                Console.WriteLine("c. Ter");
                Console.WriteLine("d. Amazones");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'd') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 4)
            {
                Console.WriteLine("Quina és la capital de Alemanya?");
                Console.WriteLine("a. Berlin");
                Console.WriteLine("b. Munic");
                Console.WriteLine("c. Hamburg");
                Console.WriteLine("d. Frankfurt");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'a') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 5)
            {
                Console.WriteLine("Digues quants oceans hi han al mon.");
                Console.WriteLine("a. 3");
                Console.WriteLine("b. 5");
                Console.WriteLine("c. 4");
                Console.WriteLine("d. 6");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'b') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else Console.WriteLine("Escolleig un numero valid");
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
                    if (Console.ReadLine().ToLower().ToLower() == "c")
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
                    if (Console.ReadLine().ToLower() == "c")
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
                    if (Console.ReadLine().ToLower() == "a")
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
                    if (Console.ReadLine().ToLower() == "b")
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


    public static void Science()
    {
        char answer;
        int questionNum;
        Console.WriteLine("Digues un num del 1 - 5");
        questionNum = Convert.ToInt32(Console.ReadLine());
        try
        {
            //All of this is the code to make the trivia work, here if you answer the num 1-5 you get a question.
            if (questionNum == 1)
            {
                Console.WriteLine("¿Cuántos planetas hay en el sistema solar?\n");
                Console.WriteLine("a. 8");
                Console.WriteLine("b. 10");
                Console.WriteLine("c. 15");
                Console.WriteLine("d. 12");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'a') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 2)
            {
                Console.WriteLine("¿Cuál es el significado del ADN?");
                Console.WriteLine("a.ácido desoxirribonucleico");
                Console.WriteLine("b. ácido desoxirribonutric");
                Console.WriteLine("c. ácido diribonucleico");
                Console.WriteLine("d. ácido diabonucleico");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'a') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 3)
            {
                Console.WriteLine("¿Cuántos pares de cromosomas tenemos los humanos?");
                Console.WriteLine("a. 22");
                Console.WriteLine("b. 25");
                Console.WriteLine("c. 24");
                Console.WriteLine("d. 23");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'd') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 4)
            {
                Console.WriteLine("¿Cuánto pesa la tierra?");
                Console.WriteLine("a. 13,370,000,000,000,000,000,000,000 libras");
                Console.WriteLine("b. 13,170,000,000,000,000,000,000,000 libras");
                Console.WriteLine("c. 15,170,000,000,000,000,000,000,000 libras");
                Console.WriteLine("d. 18,070,000,000,000,000,000,000,000 libras.");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'b') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else if (questionNum == 5)
            {
                Console.WriteLine("¿Por qué el cielo es azul?");
                Console.WriteLine("a. Porque refleja el color del océano");
                Console.WriteLine("b. Por su posición en el espacio");
                Console.WriteLine("c. Porque la luz del sol viaja a través de la atmósfera.");
                Console.WriteLine("d. Debido a la luna y la fase lunar específica");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'c') Console.WriteLine("Good job you guessed correctly");
                else Console.WriteLine("Wrong answer try again");
            }
            else Console.WriteLine("Escolleig un numero valid");
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

//This is Alex Branch 