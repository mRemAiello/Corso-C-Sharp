public abstract class Liquido
{
    public int _valore;

    public void Aggiungi(int valore)
    {
        _valore += valore;
    }
}

public class Acqua : Liquido
{
    public int ProprietaAcqua;
}

public class Vino : Liquido
{
    public int ProprietaVino;
}

public class BottigliaLiquido
{
    private Liquido _liquido;

    public BottigliaLiquido(Liquido liquido)
    {
        _liquido = liquido;
    }

    public Liquido GetLiquido()
    {
        return _liquido;
    }

    public void Versa(int valore)
    {
        _liquido.Aggiungi(valore);
    }
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