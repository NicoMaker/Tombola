public class Tombola
{
    public static int Genera1Numero(int[] numeri, int numero_passaggio, int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Random numberrandom = new Random();
        bool controllo = false;
        int conta = 0;
        int conta2 = numero_passaggio;

        if (numero_passaggio < numero - 1)
            numero_passaggio++;
        else
            conta2++;

        if (conta2 > numero - 1)
            Console.WriteLine("non posso generare perchè ho già generato 90 numeri");
        else
        {
            for (int i  = numero_passaggio; i <= numero_passaggio; i++)
            {
                numeri[i] = numberrandom.Next(1, numero + 1);

                if (i > 0)
                {
                    do
                    {
                        controllo = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (numeri[i] == numeri[j])
                            {
                                controllo = true;
                                numeri[i] = numberrandom.Next(1, numero + 1);
                            }
                            else
                                conta++;
                        }

                        if (conta == numero_passaggio)
                            controllo = true;

                    } while (controllo); 

                }
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = numero_passaggio; i <= numero_passaggio; i++)
                Console.WriteLine($"{i + 1} Numero uscito è {numeri[i]}");

    
        }

        return numero_passaggio;
    }

    public static void visualizza(int[] numeri, int numero_passaggio)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("NUMERI GENERATI");
        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i <= numero_passaggio; i++)
            Console.Write(numeri[i] + " ");

        Console.WriteLine("");
    }

    public static void Controllo(int numero_passaggio, int[] numeri)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        int numero_controllo = 0;
        bool controllo_numero = false;

        do
        {
            Console.Write("inserire numero da controllare se uscito ---> ");
            numero_controllo = Convert.ToInt32(Console.ReadLine());

        } while (numero_controllo > 90 || numero_controllo <= 0);

        Console.WriteLine(" ");

        for(int i = 0; i <= numero_passaggio; i++)
        {
            if (numero_controllo == numeri[i])
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"il numero {numero_controllo} è uscito");
                Console.WriteLine(" ");
                controllo_numero = true;
            }
        }

        if(!controllo_numero)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"il numero {numero_controllo} non è uscito");
            Console.WriteLine(" ");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("NUMERI USCITI");
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= numero_passaggio; i++)
                Console.Write($"{numeri[i]} ");

            Console.WriteLine("");
        }
    }

    public static int AzzeraVettore(int numero_passaggio)
    {
        Console.ForegroundColor = ConsoleColor.White;
        numero_passaggio = -1;
        Console.WriteLine("vettore azzerato");
        return numero_passaggio;
    }
}