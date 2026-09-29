public class Program //Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    {

        Console.WriteLine("Inserisci il nome del cliente:");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente} nella Easy Class 3E!");

        Console.WriteLine("Inserisci il tipo di spedizione:");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi acquistati:");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());

        int costoSpedizioneSingoloPacco = 5;
        costoSpedizioneSingoloPacco = 10;

        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati; 
        Console.WriteLine($"il tipo di consegna selezionato è: { tipoConsegna} e il vosto totale è {costoTotale}");

        // [tipo ] [nomeOggetti] = new[tipo](); //creo un oggetto della classe [tipo]
        Enemy newEnemy = new Enemy(); //creo un oggetto della classe Enemy

    }
}