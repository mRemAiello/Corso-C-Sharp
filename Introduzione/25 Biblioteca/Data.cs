using System.Runtime.CompilerServices;

public class Data
{
    private int _giorno;
    private int _mese;
    private int _anno;

    //
    public Data(int giorno, int mese, int anno)
    {
        _giorno = giorno;
        _mese = mese;
        _anno = anno;
    }

    //
    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        // if (obj.GetType() == typeof(Data))
        // {
        //      Data data = (Data)obj;
        // }
        if (obj is Data data)
        {
            return GetGiorno() == data.GetGiorno() && GetMese() == data.GetMese() && GetAnno() == data.GetAnno();
        }

        return false;
    }

    private int GetGiorniMese(int mese)
    {
        Mesi meseEnum = (Mesi)mese;
        return meseEnum switch
        {
            Mesi.Gennaio => 31,
            Mesi.Febbraio => 28,
            Mesi.Marzo => 31,
            Mesi.Aprile => 30,
            Mesi.Maggio => 31,
            Mesi.Giugno => 30,
            Mesi.Luglio => 31,
            Mesi.Agosto => 31,
            Mesi.Settembre => 30,
            Mesi.Ottobre => 31,
            Mesi.Novembre => 30,
            Mesi.Dicembre => 31,
            _ => 31,
        };
    }

    // Date uguale => 0
    // Data 1 (classe corrente) maggiore di data 2 => differenza in giorni
    public int CompareTo(Data data)
    {
        if (Equals(data))
            return 0;

        // Restituisco come se ogni mese fosse di 31 giorni
        // 20 Marzo
        // (365 * 2024) + (2 * 31) + 20
        // 10 Aprile
        // (365 * 2024) + (3 * 31) + 10
        // (anno - 1 * 365) + (mese - 1 * 31) + giorni
        int giorniTotali = (365 * GetAnno()) + ((GetMese() - 1) * GetGiorniMese(GetAnno())) + GetGiorno();
        int giorniTotali2 = (365 * data.GetAnno()) + ((data.GetMese() - 1) * GetGiorniMese(data.GetAnno())) + data.GetGiorno();
        return giorniTotali - giorniTotali2;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    //
    public int GetGiorno() => _giorno;
    public int GetMese() => _mese;
    public int GetAnno() => _anno;

    //
    public override string ToString()
    {
        return $"Giorno: {GetGiorno()}, Mese: {GetMese()}, Anno: {GetAnno()}";
    }
}