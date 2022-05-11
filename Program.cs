/*
 Un semplice calcolatore
 Realizzare un programma che chiede all'utente che tipo di operazione intende
 svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
 e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
 chiede un solo valore e se media chiede 10 valori.
 Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
 Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
 Opzionale: trovare il massimo;
*/
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) // entry point
        {
            
            string[] Operations  = new string[] { "somma", "moltiplicazione", "divisione", "sottrazione", "quadrato", "media", "potenza", "max"};
            Console.WriteLine("Quale operazione vuoi svolgere?");
            string sOperation = Console.ReadLine().Trim().ToLower();
            int iIndex = Array.IndexOf(Operations, sOperation);
            int res;

            if (iIndex <= 3)
            {
                Console.WriteLine("Inserisci il primo valore:");
                int iNumOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore");
                int iNumTwo = Convert.ToInt32(Console.ReadLine());

                switch (iIndex)
                {
                    case 0:
                        res = calculator.Sum(iNumOne, iNumTwo);
                        Console.WriteLine("Il risultato dell'operazione è: {0}", res);
                        break;
                    case 1:
                        res = calculator.Moltiplicator(iNumOne, iNumTwo);
                        Console.WriteLine("Il risultato dell'operazione è: {0}", res);
                        break;
                    case 2:
                        {
                            double result = calculator.Division((double)iNumOne, (double)iNumTwo);
                            Console.WriteLine("Il risultato dell'operazione è: {0}", result);
                        }
                        break;
                    case 3:
                        res = calculator.Sub(iNumOne, iNumTwo);
                        Console.WriteLine("Il risultato dell'operazione è: {0}", res);
                        break;
                    default:
                        Console.WriteLine("Richiesta non eseguibile");
                        break;
                }
            }
            if(iIndex == 4)
            {
                Console.WriteLine("Inserisci il valore:");
                int iNum = Convert.ToInt32(Console.ReadLine());
                res = calculator.Square(iNum);
                Console.WriteLine("Il risultato dell'operazione è: {0}", res);
            }
            if(iIndex == 5)
            {
                Console.WriteLine("Inserisci un elenco di numeri per il quale intendi calcolare una media");
                
                string sNumbers = Console.ReadLine();
                if (sNumbers == null)
                {
                    Console.WriteLine("Non hai fornito numeri!!");
                    Environment.Exit(0);
                }
                string[] svect = sNumbers.Split(' ');
                double med;
                med = calculator.Average(svect);
                Console.WriteLine("La media dei numeri forniti è: {0}", med);
            }
            if(iIndex == 6)
            {
                Console.WriteLine("Inserisci il primo valore:");
                int iNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo valore:");
                int iExp = Convert.ToInt32(Console.ReadLine());
                if (iNum == null || iExp == null)
                {
                    Console.WriteLine("Non hai fornito numeri!!");
                    Environment.Exit(0);
                }

                int result = calculator.Exp(iNum, iExp);

                Console.WriteLine("Il risultato è {0}", result);
            }
            if(iIndex == 7)
            {
                Console.WriteLine("Inserisci un elenco di numeri");
                string sNumbers = Console.ReadLine();
                string[] sVect = sNumbers.Split(' ');
                Console.WriteLine(sVect.Max());
            }
        }
    }
}