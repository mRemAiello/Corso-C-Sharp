public abstract class Animale : IExample
{
    public abstract void Verso();
    public abstract void Funzione();
    
    public void Dormi()
    {
        Console.WriteLine("L'animale dorme.");
    }
}