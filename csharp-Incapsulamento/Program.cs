/*
    1. Creare una classe che rispecchia il funzionamento di un telefono cellulare, chiamata Cellulare.
    Dotare la classe di quegli attributi e di quei costruttori che si ritengono necessari. Usare
    l’incapsulamento per rendere le variabili inaccessibili all’esterno e dotare la classe di getter e di
    setter per ognuna di esse.

    Dotare la classe di cinque metodi:

        a. Il metodo “chiama”, che simula una chiamata, stampando a schermo: “sto chiamando il
        numero: “, corredata da un numero di esempio. La chiamata può partire solo se il credito
        è maggiore di 0.
        b. Il metodo “creditoResiduo”, che stampa a schermo il credito residuo.
        c. Il metodo “ultimaChiamataEffettuata”, che ritorna l’ultimo numero chiamato dall’utente.
        d. Il metodo “richiama”, che chiama l’ultimo numero che è stato chiamato.
        e. Il metodo “ricaricaCredito”, che ricarica il credito del cellulare.

    Consiglio: int potrebbe essere un tipo di dato non adatto a contenere numeri di telefono,
    utilizzare String.

    2. Dopo aver fatto l’esercizio 1:
    • Istanziare un’oggetto della classe Cellulare
    • Simulare una chiamata
    • Controllare il credito residuo
    • Controllare l’ultimo numero chiamato

    3. Dato un array di numeri interi già definito come:
    int[] numeri = {1, 25, -4, 36, 0, -1, -4, 27, 3, -1, -1, 52};
    scrivere un programma che prende in input un numero intero dall’utente e stampa se questo
    numero è presente o meno nell’array numeri.

    4. Nello stesso programma dell’esercizio 3, scrivere un metodo che conti le occorrenze di un dato
    numero preso come argomento (conterà quante volte quel numero compare nell’array).

    BONUS: modificare il codice dell’esercizio 3 in modo che questo metodo sia chiamato solo
    quando è già stato stabilito se compare o meno nell’array.


*/

using System.Text.RegularExpressions;

namespace csharp_Incapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 2 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Creazione istanza classe Cellulare");
                Console.WriteLine("Caso [2]: Dato un numero intero scelto dall’utente e stampa se questo numero è presente o meno in un array");
                


                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1-2\n");

                        Cellulare mioCellulare = new Cellulare(10, "1234567890");
                        //mioCellulare.RicaricaCredito(10);
                        mioCellulare.Chiama("123456789AZE0");
                        mioCellulare.CreditoResiduo();
                        Console.WriteLine("Ultimo numero chiamato: " + mioCellulare.UltimaChiamataEffettuata());
                        mioCellulare.Richiama();


                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 2\n");
                        CheckNumber();
                        break;
               
                }

            }
        }


        /*
            Dato un array di numeri interi già definito come: int[] numeri = {1, 25, -4, 36, 0, -1, -4, 27, 3, -1, -1, 52};
            scrivere un programma che prende in input un numero intero dall’utente e stampa se questo numero è presente o meno nell’array numeri.

            Nello stesso programma dell’esercizio 3, scrivere un metodo che conti le occorrenze di un dato
            numero preso come argomento (conterà quante volte quel numero compare nell’array).

            BONUS: modificare il codice dell’esercizio 3 in modo che questo metodo sia chiamato solo
            quando è già stato stabilito se compare o meno nell’array.
       */
        static void CheckNumber()
        {
            int[] numeri = { 1, 25, -4, 36, 0, -1, -4, 27, 3, -1, -1, 52 };

            int var;

            Console.Write("\nInserire un valore da ricercare:  ");

            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out var))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nRicerca del valore nell'array......");

            for (int i = 0; i < numeri.Length; i++)
            {
                
                if (numeri[i] == var)
                {
                    //prima posizione utile nell'array
                    Console.WriteLine("\nValore trovato in posizione: {0}=>[{1}]\n",i+1,i);

                    //stampo l'array su una sola riga
                    Console.WriteLine(string.Join(" ", numeri));

                    // Conta le occorrenze solo se il numero è presente
                    int conteggio = ContaOccorrenze(numeri, var);
                    Console.WriteLine($"Il numero {var} è presente nell'array e compare {conteggio} volta(e).");

                    // Cerca le altre occorrenze
                    for (int j = 0; j < numeri.Length; j++)
                    {

                        if (numeri[j] == var)
                        {
                            //prima posizione utile nell'array
                            Console.WriteLine("\n In posizione: {0}=>[{1}]\n", j + 1, j);
                            continue;
                        }
                    }

                   break;
                }
                // Se arrivo alla fine dell'array e non ho trovato il valore
                if (i == numeri.Length - 1)
                {
                    Console.WriteLine("\nValore non trovato");
                }

            }

        }

        // Metodo che conta le occorrenze di un numero nell'array
        static int ContaOccorrenze(int[] array, int numero)
        {
            int conteggio = 0;

            foreach (int elemento in array)
            {
                if (elemento == numero)
                {
                    conteggio++;
                }
            }
            return conteggio;
        }

    }

    /*
            Creare una classe che rispecchia il funzionamento di un telefono cellulare, chiamata Cellulare.
            Dotare la classe di quegli attributi e di quei costruttori che si ritengono necessari.
            Usare l’incapsulamento per rendere le variabili inaccessibili all’esterno e dotare la classe di getter e di setter per ognuna di esse.

            Dotare la classe di cinque metodi:

            a. Il metodo “chiama”, che simula una chiamata, stampando a schermo: “sto chiamando il
            numero: “, corredata da un numero di esempio. La chiamata può partire solo se il credito
            è maggiore di 0.
            b. Il metodo “creditoResiduo”, che stampa a schermo il credito residuo.
            c. Il metodo “ultimaChiamataEffettuata”, che ritorna l’ultimo numero chiamato dall’utente.
            d. Il metodo “richiama”, che chiama l’ultimo numero che è stato chiamato.
            e. Il metodo “ricaricaCredito”, che ricarica il credito del cellulare. 
     
    */

    public class Cellulare
    {
        // Attributi privati
        private double credito;
        private string numeroChiamato;

        // Getter e Setter
        public double Credito
        {
            get { return credito; }
            set {

                if (value <= 0)
                {
                    Console.WriteLine("Errore: Inserire credito maggiore di zero");
                }
                else
                {
                    if (value < credito) // Se il valore è diminuito (credito decrementato)
                    {
                        Console.WriteLine("Il credito è stato utilizzato. Nuovo saldo: {0}", value);
                    }
                    else if (value > credito) // Se il valore è aumentato (credito ricaricato)
                    {
                        Console.WriteLine("Credito ricaricato! Nuovo saldo: {0}", value);
                    }

                    credito = value; // Assegna il nuovo valore
                }
            
            }
        }

        public string NumeroChiamato
        {
            get { return numeroChiamato; }
            set 
            { 
                // Controllo: il numero deve contenere solo cifre
                if (!Regex.IsMatch(value, @"^\d+$"))
                {
                    Console.WriteLine("Errore: Il numero di telefono deve contenere solo cifre.\n");
                }
                else
                {
                    numeroChiamato = value;
                }


            }
        }

        // Costruttore parametrizzato
        public Cellulare(double credito, string numeroChiamato)
        {
            Credito = credito;
            NumeroChiamato = numeroChiamato;
        }

        // Costruttore vuoto
        public Cellulare() { }

        // Metodi
        public void Chiama(string numero)
        {
            if (Credito > 0)
            {
                Console.WriteLine("\nSto chiamando il numero: {0} \n",numero);

                // Controllo: il numero deve contenere solo cifre
                if (!Regex.IsMatch(numero, @"^\d+$"))
                {
                    Console.WriteLine("Errore: Il numero di telefono deve contenere solo cifre.\n");
                }
                else
                {
                    NumeroChiamato = numero;

                    Credito -= 5; // Simulazione del consumo di credito
                }


            }
            else
            {
                Console.WriteLine("Credito insufficiente per effettuare la chiamata.");
            }
        }

        public void CreditoResiduo()
        {
            //stampa credito residuo
            Console.WriteLine("Credito residuo: " + Credito);
        }

        public string UltimaChiamataEffettuata()
        {
            //restituisci l'ultimo numero chiamato
            return NumeroChiamato;
        }

        public void Richiama()
        {
            if (!string.IsNullOrEmpty(NumeroChiamato))
            {
                Chiama(NumeroChiamato);
            }
            else
            {
                Console.WriteLine("Nessun numero da richiamare.");
            }
        }

        public void RicaricaCredito(double importo)
        {
            //Credito += importo;
            Console.WriteLine("Credito ricaricato di: " + Credito);
        }
    }
}
