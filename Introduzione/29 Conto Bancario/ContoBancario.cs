// Esercizio 4: Property calcolata e campi privati
// Descrizione: Crea una classe ContoBancario con proprietà per il saldo e il tasso di interesse. 
// Implementa una property calcolata InteresseAnnuale che restituisca il guadagno sugli interessi per un anno.

public class ContoCorrente
{
    public float Saldo { get; private set; } = 0;
    public float TassoDiInteresse { get; private set; } = 0;
    public float InteresseAnnuale { get => Saldo * TassoDiInteresse / 1000; }

    //
    public ContoCorrente(float saldo = 0, float tassoDiInteresse = 0)
    {
        AggiungiSaldo(saldo);
        CambiaTassoDiInteresse(tassoDiInteresse);
    }

    public void AggiungiSaldo(float saldo)
    {
        if (saldo <= 0)
        {
            Console.WriteLine("Per favore inserire un saldo positivo");
            return;
        }

        Saldo += saldo;
    }

    public void CambiaTassoDiInteresse(float tassoDiInteresse)
    {
        if (tassoDiInteresse <= 0)
        {
            Console.WriteLine("Non puoi avere un tasso di interesse nullo o negativo");
            return;
        }

        TassoDiInteresse = tassoDiInteresse;
    }
}