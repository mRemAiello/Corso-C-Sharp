/*class Program
{
    static void Main(string[] args)
    {
        // Elemento Multimediale
        ElementoMultimediale elemento = new ElementoMultimediale("Rock of Ages");
        Console.WriteLine(elemento.GetTitolo());
        elemento.SetTitolo("");

        // Elemento Riproducibile
        ElementoRiproducibile elemRiproducibile = new ElementoRiproducibile("ciao", 10);
        Console.WriteLine(elemRiproducibile.GetDurata());

        // Immagine
        Immagine img = new Immagine("Foto delle vacanze al mare", 40, 0, 100);
        img.SetLuminosita(200);
        Console.WriteLine(img.GetLuminosita());
        img.Mostra();

        //
        Audio audio = new Audio("Rock of Ages", 3, 40, 0, 100);
        audio.SetVolume(100);
        if (audio.Riproducibile())
            audio.Riproduci();

        //
        Filmato filmato = new Filmato("Rock of Ages", 3, 0, 100, 1, 100);
        filmato.SetVolume(10);
        filmato.SetLuminosita(30);
        filmato.AumentaVolume(20);
        if (filmato.Riproducibile())
            filmato.Riproduci();

        // ToString
        // Il ToString => elemento => elemento.ToString() => stampa su console la stringa restituita da ToString()
        Console.WriteLine(elemento);
        Console.WriteLine(elemRiproducibile);
        Console.WriteLine(img);
        Console.WriteLine(audio);
        Console.WriteLine(filmato);
    }
}*/