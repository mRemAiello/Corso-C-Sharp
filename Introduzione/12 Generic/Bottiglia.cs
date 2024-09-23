public class Liquido
{
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
}