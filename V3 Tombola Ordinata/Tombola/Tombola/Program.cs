int scelta = 0, numero_passaggio = -1;
const int numero = 90;
int[] numeri = new int[numero];
int[] numeri_ordinati = new int[numero];

do
{
    scelta = Menu();

    switch(scelta)
    {
        case 1:
            Console.Clear();
            Console.WriteLine(" ");
            numero_passaggio = Tombola.Genera1Numero(numeri, numero_passaggio, numero, numeri_ordinati);
            Console.WriteLine("");
            Tombola.visualizza(numeri, numero_passaggio, numeri_ordinati);
            Console.WriteLine("");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine(" ");
            Tombola.visualizza(numeri, numero_passaggio, numeri_ordinati);
            Console.WriteLine(" ");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine(" ");
            Tombola.Controllo(numero_passaggio,numeri, numeri_ordinati);
            Console.WriteLine(" ");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine(" ");
            numero_passaggio = Tombola.AzzeraVettore(numero_passaggio,numeri_ordinati, numero);
            Console.WriteLine(" ");
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ");
            Console.WriteLine("TASTO INVALIDO");
            break;
    }

    Console.WriteLine("");
    Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
    Console.ReadKey();
    Console.WriteLine("");

} while(scelta != 0);

int Menu()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("");
    Console.Clear();
    Console.WriteLine("1. genera 1 numero per 90 volte");
    Console.WriteLine("2. visualizza numeri usciti");
    Console.WriteLine("3. inserisci numero da tastiera e vedi se è uscito altrimenti stampa quelli usciti");
    Console.WriteLine("4. azzera vettore e inizio nuova partita");
    Console.WriteLine("0. uscita");

    Console.WriteLine(" ");

    Console.Write("inserisci scelta ---> ");
    int scelta = Convert.ToInt32(Console.ReadLine());

    return scelta;
}