namespace DelegateExample
{
    // Definizione del delegate
    public delegate int Operation(int x, int y);

    class DelegateEx
    {
        //
        public Operation? Operation { get; set; }

        // Metodo che somma due numeri
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Metodo che sottrae due numeri
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        public void Execute()
        {
            // Creazione di un'istanza del delegate e assegnazione del metodo Add
            Operation op = Add;

            // Chiamata del metodo tramite il delegate
            int result = op(10, 5);
            Console.WriteLine("Somma: " + result);  // Output: Somma: 15

            // Riassegnazione del delegate al metodo Subtract
            op = Subtract;

            // Chiamata del metodo tramite il delegate
            result = op(10, 5);
            Console.WriteLine("Sottrazione: " + result);  // Output: Sottrazione: 5

            //
            op = Add;
            op += Subtract;

            //
            result = op(10, 25);
            Console.WriteLine("Risultato: " + result);
        }
    }
}
