using System.Runtime.InteropServices.ComTypes;
using System.Text;

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
            for (int i = numero_passaggio; i <= numero_passaggio; i++)
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

    public static void PrimaParteHTML(int[] numeri, int numero_passaggio)
    {
        File.Delete("Tombola.html");
        var sb = new StringBuilder();
        bool controllo = false;

        sb.Append(@"<!DOCTYPE html>
        <html>
                <head>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap"" rel=""stylesheet"">
                <title> Tombola </title>
                <link rel=""stylesheet"" href=""Parte_Grafica.css"">
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
                <body>"
        );

        sb.Append("<h1> Gioco Tombola </h1>");
        sb.Append("<img class=\"Immagine\" src=\"Tombola.jpg\">");

        sb.Append("<br>");

        if (numero_passaggio > 89)
            sb.Append(@"
            <p> non posso generare più di 90 numeri </p>");
        else
        {
            for (int i = numero_passaggio; i <= numero_passaggio; i++)
                sb.Append($@"
                <p> il {numero_passaggio + 1} numero uscito è ----> {numeri[i]} </p>
                ");
        }

        sb.Append("<h1 class = Titolo_Scritte > Numeri Usciti </h1>");

        sb.Append("<br>");

        sb.Append("<table> <tr>");

        for (int i = 0; i <= numero_passaggio; i++)
        {
            if (i % 10 == 0)
            {
                sb.Append($@"<tr> 
                            <td>
                            {numeri[i]}
                            </td>
                ");
                controllo = true;
            }
            else
            {
                sb.Append($@"
                <td>
                    {numeri[i]}
                </td>
                ");
            }
        }

        if (controllo)
            sb.Append("</ tr >");

        sb.Append(" </tr> </table>");
        sb.Append("</body> </html>");

        sb.Append("</body> </html>");

        File.WriteAllText("Tombola.html", sb.ToString());
    }

    public static void visualizza(int[] numeri, int numero_passaggio)
    {
        
        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.White;

        if (numero_passaggio < 0)
            Console.WriteLine("non è uscito nessun numero perchè ancora non è stato generato");
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("NUMERI GENERATI");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= numero_passaggio; i++)
                Console.Write(numeri[i] + " ");
        }

        Console.WriteLine("");
    }

    public static void VisualizzaPaginaHTML(int[] numeri, int numero_passaggio)
    {
        File.Delete("Tombola.html");

        var sb = new StringBuilder();
        bool controllo = false;

        sb.Append(@"<!DOCTYPE html>
        <html>
                <head>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap"" rel=""stylesheet"">
                <title> Tombola </title>
                <link rel=""stylesheet"" href=""Parte_Grafica.css"">
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
                <body>"
        );

        sb.Append("<h1> Gioco Tombola </h1>");
        sb.Append("<img class=\"Immagine\" src=\"Tombola.jpg\">");

        if (numero_passaggio < 0)
            sb.Append("<p> non è uscito nessun numero perchè ancora non è stato generato </p>");
        else
        {
            sb.Append("<h1 class = Titolo_Scritte > Numeri Usciti </h1>");

            sb.Append("<br>");

            sb.Append("<table> <tr>");

            for (int i = 0; i <= numero_passaggio; i++)
            {
                if (i % 10 == 0)
                {
                    sb.Append($@"<tr> 
                            <td>
                            {numeri[i]}
                            </td>
                ");
                    controllo = true;
                }
                else
                {
                    sb.Append($@"
                <td>
                    {numeri[i]}
                </td>
                ");
                }
            }

            if (controllo)
                sb.Append("</ tr >");

            sb.Append(" </tr> </table>");
        }
        sb.Append("</body> </html>");

        File.WriteAllText("Tombola.html", sb.ToString());
    }

    public static void Controllo(int numero_passaggio, int[] numeri)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        int numero_controllo = 0;
        bool controllo_numero = false, controllo = false;

        if(numero_passaggio < 0)
            Console.WriteLine("non posso controllare alcun numero perchè non è stato genrato nessuno");
        else
        {
            do
            {
                Console.Write("inserire numero da controllare se uscito ---> ");
                numero_controllo = Convert.ToInt32(Console.ReadLine());

            } while (numero_controllo > 90 || numero_controllo <= 0);

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

                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i <= numero_passaggio; i++)
                    Console.Write($"{numeri[i]} ");

                Console.WriteLine("");
            }
        }
    
        File.Delete("Tombola.html");

        var sb = new StringBuilder();

        sb.Append(@"<!DOCTYPE html>
        <html>
                <head>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap"" rel=""stylesheet"">
                <title> Tombola </title>
                <link rel=""stylesheet"" href=""Parte_Grafica.css"">
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
                <body>"
        );

        sb.Append("<h1> Gioco Tombola </h1>");
        sb.Append("<img class=\"Immagine\" src=\"Tombola.jpg\">");

        sb.Append("<br>");


        if(numero_passaggio < 0)
            sb.Append("<p> non posso controllare alcun numero perchè non è stato genrato nessuno </p>");
        else
        {
            if (controllo_numero)
                sb.Append($@"<p> il numero {numero_controllo} è uscito");
            else
            {
                sb.Append($@"<p> il numero {numero_controllo} non è uscito");
                sb.Append("<h1 class = Titolo_Scritte > Sono usciti i Seguenti numeri </h1>");

                sb.Append("<table> <tr>");

                for (int i = 0; i <= numero_passaggio; i++)
                {
                    if (i % 10 == 0)
                    {
                        sb.Append($@"<tr> 
                            <td>
                            {numeri[i]}
                            </td>
                            ");
                        controllo = true;
                    }
                    else
                    {
                        sb.Append($@"
                    <td>
                    {numeri[i]}
                    </td>
                    ");
                    }
                }

                if (controllo)
                    sb.Append("</ tr >");

                sb.Append(" </tr> </table>");
                sb.Append("</body> </html>");

                sb.Append(" </tr> </table>");
            }
        }

        sb.Append("</body> </html>");

        File.WriteAllText("Tombola.html", sb.ToString());
    }

    public static int AzzeraVettore(int numero_passaggio)
    {
        Console.ForegroundColor = ConsoleColor.White;
        numero_passaggio = -1;
        Console.WriteLine("vettore azzerato");
        return numero_passaggio;
    }

    public static void AzzeraHTML()
    {
        File.Delete("Tombola.html");

        var sb = new StringBuilder();

        sb.Append(@"<!DOCTYPE html>
        <html>
                <head>
                <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap"" rel=""stylesheet"">
                <title> Tombola </title>
                <link rel=""stylesheet"" href=""Parte_Grafica.css"">
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
                <body>"
        );

        sb.Append("<h1> Gioco Tombola </h1>");
        sb.Append("<img class=\"Immagine\" src=\"Tombola.jpg\">");

        sb.Append("<p> inizio nuova partita </p>");

        sb.Append("</body> </html>");

        File.WriteAllText("Tombola.html", sb.ToString());
    }
}