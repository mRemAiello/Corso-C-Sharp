public class Liquido
{
    public int _valore;

    public void Aggiungi(int valore)
    {
        _valore += valore;
    }
}

public class Acqua : Liquido
{
}

public class Vino : Liquido
{
}

public class BottigliaDiAcqua
{
    private Acqua _acqua;

    public BottigliaDiAcqua(Acqua acqua)
    {
        _acqua = acqua;
    }

    public void Versa(int valore)
    {
        _acqua.Aggiungi(valore);
    }
}

public class BottigliaDiVino
{
    private Vino _vino;

    public BottigliaDiVino(Vino vino)
    {
        _vino = vino;
    }

    public void Versa(int valore)
    {
        _vino.Aggiungi(valore);
    }
}