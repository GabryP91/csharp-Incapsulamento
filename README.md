# csharp-Incapsulamento

1. Creare una classe che rispecchia il funzionamento di un telefono cellulare, chiamata Cellulare.
    Dotare la classe di quegli attributi e di quei costruttori che si ritengono necessari. Usare
    l’incapsulamento per rendere le variabili inaccessibili all’esterno e dotare la classe di getter e di
    setter per ognuna di esse.
   
    Dotare la classe di quattro metodi:
   
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

  scrivere un programma che prende in input un numero intero dall’utente e stampa se questo numero è presente o meno nell’array numeri.
  
4. Nello stesso programma dell’esercizio 3, scrivere un metodo che conti le occorrenze di un dato
   numero preso come argomento (conterà quante volte quel numero compare nell’array).
   BONUS: modificare il codice dell’esercizio 3 in modo che questo
