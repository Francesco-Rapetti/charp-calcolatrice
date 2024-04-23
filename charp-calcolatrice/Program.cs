/*
    Creare una classe di helper CalcoliHelper.
    Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
    - Somma di due numeri interi
    - Somma di due numeri double
    - Differenza tra due numeri interi
    - Differenza tra due numeri double
    - Moltiplicazione di due numeri interi
    - Moltiplicazione di due numeri double
    - Valore assoluto di un numero intero
    - Valore assoluto di un numero double
    - Minimo tra due numeri interi
    - Minimo tra due numeri double
    - Massimo tra due numeri interi
    - Massimo tra due numeri double
    Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
    Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
    **BONUS**:
    Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
    (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
 */
namespace charp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 5;
            double c = 6.3;
            double d = 5.6;
            int e = -6;
            int f = -3;
            double g = -6.3;
            double h = -5.6;
            // Somma
            Console.WriteLine(Prettifier($"Somma di {a} e {b}"));
            Console.WriteLine(CalcoliHelper.Somma(a, b));
            Console.WriteLine(Prettifier($"Somma di {c} e {d}"));
            Console.WriteLine(CalcoliHelper.Somma(c, d));
            Console.WriteLine();

            // Sottrazione
            Console.WriteLine(Prettifier($"Sottrazione di {a} e {b}"));
            Console.WriteLine(CalcoliHelper.Sottrazione(a, b));
            Console.WriteLine(Prettifier($"Sottrazione di {c} e {d}"));
            Console.WriteLine(CalcoliHelper.Sottrazione(c, d));
            Console.WriteLine();

            // Moltiplicazione
            Console.WriteLine(Prettifier($"Moltiplicazione di {a} e {b}"));
            Console.WriteLine(CalcoliHelper.Moltiplicazione(a, b));
            Console.WriteLine(Prettifier($"Moltiplicazione di {c} e {d}"));
            Console.WriteLine(CalcoliHelper.Moltiplicazione(c, d));
            Console.WriteLine();

            // Valore assoluto
            Console.WriteLine(Prettifier($"Valore assoluto di {e}"));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(e));
            Console.WriteLine(Prettifier($"Valore assoluto di {h}"));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(h));
            Console.WriteLine();

            // Valore minimo
            Console.WriteLine(Prettifier($"Valore minimo tra {a} e {b}"));
            Console.WriteLine(CalcoliHelper.ValoreMinimo(a, b));
            Console.WriteLine(Prettifier($"Valore minimo tra {c} e {d}"));
            Console.WriteLine(CalcoliHelper.ValoreMinimo(c, d));
            Console.WriteLine();

            // Valore massimo
            Console.WriteLine(Prettifier($"Valore massimo tra {a} e {b}"));
            Console.WriteLine(CalcoliHelper.ValoreMassimo(a, b));
            Console.WriteLine(Prettifier($"Valore massimo tra {c} e {d}"));
            Console.WriteLine(CalcoliHelper.ValoreMassimo(c, d));
            Console.WriteLine();

            // Potenza
            Console.WriteLine(Prettifier($"Potenza di {a} e {b}"));
            Console.WriteLine(CalcoliHelper.Potenza(a, b));
            Console.WriteLine(Prettifier($"Potenza di {a} e {e}"));
            Console.WriteLine(CalcoliHelper.Potenza(a, e));
            Console.WriteLine(Prettifier($"Potenza di {a} e {f}"));
            Console.WriteLine(CalcoliHelper.Potenza(a, f));
            Console.WriteLine(Prettifier($"Potenza di {a} e {0}"));
            Console.WriteLine(CalcoliHelper.Potenza(a, 0));
            Console.WriteLine(Prettifier($"Potenza di {0} e {b}"));
            Console.WriteLine(CalcoliHelper.Potenza(0, b));
            Console.WriteLine(Prettifier($"Potenza di {0} e {0}"));
            Console.WriteLine(CalcoliHelper.Potenza(0, 0));
        }

        private static string Prettifier(string input)
              => $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
    }
}
