public class Stringhe
{
    public void Execute()
    {  
        // ToUpper() - Converte la stringa in maiuscolo.

        // ToLower() - Converte la stringa in minuscolo.

        // Trim() - Rimuove gli spazi vuoti all’inizio e alla fine.

        // Replace(oldValue, newValue) - Sostituisce le occorrenze di oldValue con newValue.

        // Substring(startIndex) - Restituisce una sottostringa a partire dall’indice specificato.

        // Contains(substring) - Verifica se la stringa contiene la sottostringa.

        // IndexOf(substring) - Restituisce l’indice della prima occorrenza della sottostringa.

        // StartsWith(prefix) - Verifica se la stringa inizia con il prefisso.

        // EndsWith(suffix) - Verifica se la stringa termina con il suffisso.

        // Split(separator) - Divide la stringa in un array di sottostringhe basate sul separatore.

        // ToUpper(): Converte la stringa in maiuscolo.

        string maiuscolo = "hello".ToUpper(); // "HELLO"

        // ToLower(): Converte la stringa in minuscolo.

        string minuscolo = "WORLD".ToLower(); // "world"

        // Trim(): Rimuove gli spazi vuoti all’inizio e alla fine.

        string spazi = "   Ciao   ".Trim(); // "Ciao"

        // Replace(oldValue, newValue): Sostituisce le occorrenze di un valore con un altro.

        string sostituito = "Ciao mondo".Replace("Ciao", "Salve"); // "Salve mondo"

        // Substring(startIndex): Restituisce una sottostringa a partire dall’indice specificato.

        string sottostringa = "Esempio".Substring(3); // "mpio"

        // Contains(substring): Verifica se la stringa contiene la sottostringa.

        bool contiene = "Ciao mondo".Contains("mondo"); // true

        // IndexOf(substring): Restituisce l’indice della prima occorrenza della sottostringa.

        int indice = "Ciao mondo".IndexOf("mondo"); // 5

        // StartsWith(prefix): Verifica se la stringa inizia con il prefisso.

        bool iniziaCon = "Ciao mondo".StartsWith("Ciao"); // true

        // EndsWith(suffix): Verifica se la stringa termina con il suffisso.

        bool terminaCon = "Ciao mondo".EndsWith("mondo"); // true

        // Split(separator): Divide la stringa in un array di sottostringhe basate sul separatore.

        string[] parti = "apple,banana,grape".Split(','); // ["apple", "banana", "grape"]
    }
}