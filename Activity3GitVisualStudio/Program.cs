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
                //case ConsoleKey.D1:
                   // Geography();
                   // break;

                //case ConsoleKey.D2:
                  //   History();
                    // break;

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
                Console.WriteLine("hola");
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