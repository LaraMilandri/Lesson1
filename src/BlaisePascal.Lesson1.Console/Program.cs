public class Program //Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella libreria Easy Class 3E!");
        int costoSpedizioneSingoloPacco = 5;
        costoSpedizioneSingoloPacco = 10;

        int costoSpedizione = 5; 
        string tipoConsegna = "Standard";
        int numeroPacchiComprati = 2; 

        int costoTotale = costoSpedizione * numeroPacchiComprati; 
        Console.WriteLine($"il tipo di consegna selezionato è: { tipoConsegna} e il vosto totakle è {costoTotale}");




    }
}