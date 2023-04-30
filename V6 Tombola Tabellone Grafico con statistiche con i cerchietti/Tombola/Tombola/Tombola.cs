using System.Text;

public class Tombola
{
    public static int Genera1Numero(int[] numeri, int numero_passaggio, int numero, int[] numeri_ordinati)
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

                numeri_ordinati[numeri[i] - 1] = numeri[i];
            }

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = numero_passaggio; i <= numero_passaggio; i++)
                Console.WriteLine($"{i + 1} Numero uscito è {numeri[i]}");
        }

        Console.ForegroundColor = ConsoleColor.White;

        return numero_passaggio;
    }

    public static void visualizza(int[] numeri, int numero_passaggio, int[] numeri_ordinati)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("NUMERI GENERATI");
        Console.WriteLine(" ");


        for(int i = 0; i < numeri_ordinati.Length; i++)
        {
            if (numeri_ordinati[i] != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(numeri_ordinati[i] + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(i + 1 + " ");
            }
        }

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
    }

    public static void Controllo(int numero_passaggio, int[] numeri, int[] numeri_ordinati , int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        int numero_controllo = 0;
        bool controllo_numero = false;


        if (numero_passaggio < 0)
            Console.WriteLine("non posso controllare alcun numero perchè non è stato genrato nessuno numero");
        else
        {
            do
            {
                Console.Write("inserire numero da controllare se uscito ---> ");
                numero_controllo = Convert.ToInt32(Console.ReadLine());

            } while (numero_controllo > numero || numero_controllo <= 0);

            Console.WriteLine(" ");


            for (int i = 0; i <= numero_passaggio; i++)
            {
                if (numero_controllo == numeri[i])
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"il numero {numero_controllo} è uscito");
                    Console.WriteLine(" ");
                    controllo_numero = true;
                }
            }

            if (!controllo_numero)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"il numero {numero_controllo} non è uscito");
                Console.WriteLine(" ");


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("NUMERI USCITI");
                Console.WriteLine(" ");

                for (int i = 0; i < numeri_ordinati.Length; i++)
                {
                    if (numeri_ordinati[i] != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(numeri_ordinati[i] + " ");
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
            }
        }
    }

    public static int AzzeraVettore(int numero_passaggio, int[] numeri_ordianti, int numero)
    {
        Console.ForegroundColor = ConsoleColor.White;
        numero_passaggio = -1;
        Console.WriteLine("vettore azzerato");

        for (int i = 0; i < numero; i++)
            numeri_ordianti[i] = 0;

        return numero_passaggio;
    }

    public static void ParteHTML(int[] numeri_ordinati)
    {
        File.Delete("Tombola_Tabellone.html");

        var HTML = new StringBuilder();
        bool controllo = false;

        HTML.Append(@"<!DOCTYPE html>
        <html>
                <head>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap"" rel=""stylesheet"">
                <title> Tombola </title>
                <link rel=""stylesheet"" href=""Parte_Grafica_Tabellone.css"">
                <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
                <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
                <link href=""https://fonts.googleapis.com/css2?family=Dancing+Script:wght@500&display=swap"" rel=""stylesheet"">
                <link rel=""preconnect"" href=""https://fonts.googleapis.com"">

                <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
                <link href=""https://fonts.googleapis.com/css2?family=Hubballi&display=swap"" rel=""stylesheet"">

                <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
                <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@300&display=swap"" rel=""stylesheet"">

                <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
                <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>

                </head>
                <body>
        ");


        HTML.Append("<h1> Gioco Tombola Tabellone </h1>");

        HTML.Append("<br>");

        HTML.Append("<table> <tr>");

        for (int i = 0; i < numeri_ordinati.Length; i++) 
        { 
            if(i % 10 == 0)
            {
                HTML.Append("<tr>");

                if (numeri_ordinati[i] != 0)
                    HTML.Append($@"

                      <td>
                               <div class=""contorno, Rosso"">
                                        <p class=""colore"">
                                                {numeri_ordinati[i]}
                                        </p></div>
                                
                        </td>
                      ");

                else
                    HTML.Append($@"<td>
                                <div class=""contorno"">
                                        <p>
                                                {i+1}
                                        </p></div>
                                
                        </td>");
                controllo = true;
            }
            else
            {
                if (numeri_ordinati[i] != 0)
                    HTML.Append($@"

                      <td>
                               <div class=""contorno, Rosso"">
                                        <p class=""colore"">
                                                {numeri_ordinati[i]}
                                        </p></div>
                                
                        </td>
                      ");
                else
                    HTML.Append($@"<td>
                                <div class=""contorno"">
                                        <p>
                                                {i+1}
                                        </p></div>
                                
                        </td>");
            }
        }

        if (controllo)
            HTML.Append("</ tr >");

        HTML.Append("</body> </html>");

        File.WriteAllText("Tombola_Tabellone.html", HTML.ToString());
    }
}