using Class1;
using BlaisePascal.Lesson1.ClassVehicle;

public class Program //Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    {

        /*
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
        Console.WriteLine($"il tipo di consegna selezionato è: { tipoConsegna} e il vosto totale è {costoTotale}");*/

        // [tipo ] [nomeOggetti] = new[tipo](); //creo un oggetto della classe [tipo]
       /* Enemy enemy = new Enemy(); //creo un oggetto della classe Enemy
        
        enemy.Health = 80; //assegno un valore alla proprietà Health dell'oggetto Enemy
        Console.WriteLine("Enemy Health: " + enemy.Health);
       */



        
        Vehicle vehicle = new Vehicle("AB123CD");
        //vehicle.LicensePlate = "AB123CD";
        string license = vehicle.LicensePlate;

        
        Console.WriteLine(license);
    }
}