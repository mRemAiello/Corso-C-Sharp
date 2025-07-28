public abstract class Animale
{
    public virtual void EmettiVerso()
    {
        // Implemento qualcosa
    }

    public void Dormi()
    {
        Console.WriteLine("L'animale dorme.");
    }

    public abstract bool CanRun();
    public abstract bool CanFly();
}

// Proprietà della classe astratta
// Una classe definita abstract potrebbe NON avere metodi astratti.
// Una classe che ha almeno 1 metodo astratto deve essere astratta.

// Animale
// Cane, Gatto : Animale

// Animale -> Verso(), Funzione()
// Cane cane = new Cane();