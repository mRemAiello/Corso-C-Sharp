public class GestoreMagazzino
{
    public Prodotto?[] prodotti;
    public int prodottiInseriti = 0;
    public int defaultProdottiLunghezza = 3;
    public int costoMagazzinaggio;

    public GestoreMagazzino()
    {
        prodotti = new Prodotto[defaultProdottiLunghezza];
        costoMagazzinaggio = 1;
    }

    public GestoreMagazzino(int dimensione, int costoMagazzinaggio)
    {
        prodotti = new Prodotto[dimensione];
        this.costoMagazzinaggio = costoMagazzinaggio;
    }

    public GestoreMagazzino(int costoMagazzinaggio)
    {
        prodotti = new Prodotto[defaultProdottiLunghezza];
        this.costoMagazzinaggio = costoMagazzinaggio;
    }

    public GestoreMagazzino(Prodotto[] prodotti, int costoMagazzinaggio)
    {
        this.prodotti = prodotti;
        this.costoMagazzinaggio = costoMagazzinaggio;
    }

    public void AggiungiProdotto(string? nome, int scorta)
    {
        if (scorta <= 0)
        {
            Console.WriteLine("La scorta non può essere zero o negativa");
            return;
        }

        //
        Prodotto? prodotto = CercaProdotto(nome);
        if (prodotto == null)
        {
            if (prodottiInseriti + 1 > prodotti.Length)
            {
                Console.WriteLine("Non c'è più spazio nel magazzino");
                return;
            }

            //
            for (int i = 0; i < prodotti.Length; i++)
            {
                if (prodotti[i] == null && nome != null)
                {
                    prodotti[i] = new Prodotto(nome, scorta);
                    prodottiInseriti++;
                    Console.WriteLine("Prodotto " + nome + " aggiunto al magazzino");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Aumentata scorta di " + nome);
            prodotto.scorta += scorta;
        }
    }

    public void AggiungiProdotto(string nomePrimo, int scortaPrimo, string nomeSecondo, int scortaSecondo)
    {
        AggiungiProdotto(nomePrimo, scortaPrimo);
        AggiungiProdotto(nomeSecondo, scortaSecondo);
    }

    public void AggiungiProdotto(Prodotto[] prodotti)
    {
        foreach (Prodotto prodotto in prodotti)
        {
            AggiungiProdotto(prodotto.nome, prodotto.scorta);
        }
    }

    public void SetPrezzo(string nome, float prezzo)
    {
        Prodotto? prodotto = CercaProdotto(nome);
        if (prodotto == null)
        {
            Console.WriteLine("Il prodotto " + nome + " non esiste");
            return;
        }

        //
        prodotto.prezzo = prezzo;
    }

    public void RimuoviProdotto(string nome)
    {
        Prodotto? prodotto = CercaProdotto(nome);
        if (prodotto == null)
        {
            Console.WriteLine("Il prodotto " + nome + " non esiste");
            return;
        }

        int i = CercaIndiceProdotto(nome);
        prodotti[i] = null;
    }

    public Prodotto? CercaProdotto(string? nome)
    {
        foreach (Prodotto? prodotto in prodotti)
        {
            if (prodotto != null && prodotto.nome != null && prodotto.nome.Equals(nome))
            {
                return prodotto;
            }
        }
        return null;
    }

    public int CalcolaCostoMagazzinaggio()
    {
        int costo = 0;
        foreach (Prodotto? prodotto in prodotti)
        {
            if (prodotto != null)
            {
                costo += prodotto.scorta * costoMagazzinaggio;
            }
        }
        return costo;
    }

    public int CercaIndiceProdotto(string? nome)
    {
        int i = 0;
        foreach (Prodotto? prodotto in prodotti)
        {
            if (prodotto != null && prodotto.nome != null && prodotto.nome.Equals(nome))
            {
                return i;
            }
            i++;
        }
        return -1;
    }

    public override string ToString()
    {
        string ret = "Costo Magazzinaggio: " + costoMagazzinaggio + "\n";
        ret += "Lista prodotti del magazzino\n";
        foreach (Prodotto? prodotto in prodotti)
        {
            if (prodotto != null && prodotto.nome != null)
            {
                ret += prodotto.ToString() + "\n";
            }
        }
        return ret;
    }
}