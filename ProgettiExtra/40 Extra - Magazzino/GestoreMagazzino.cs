public class GestoreMagazzino
{
    public List<Prodotto?> prodotti;
    public int costoMagazzinaggio;

    public GestoreMagazzino()
    {
        prodotti = [];
        costoMagazzinaggio = 1;
    }

    public GestoreMagazzino(int costoMagazzinaggio)
    {
        prodotti = [];
        this.costoMagazzinaggio = costoMagazzinaggio;
    }

    public GestoreMagazzino(Prodotto[] prodotti, int costoMagazzinaggio)
    {
        this.prodotti = [];
        this.prodotti.AddRange(prodotti);
        this.costoMagazzinaggio = costoMagazzinaggio;
    }

    private bool CheckProductInput(string? nome, int scorta)
    {
        if (scorta <= 0)
        {
            Console.WriteLine("La scorta non può essere zero o negativa");
            return false;
        }

        if (nome == null)
        {
            Console.WriteLine("Il nome non può essere null");
            return false;
        }

        return true;
    }

    public void AggiungiProdotto(string nome, int scorta)
    {
        if (!CheckProductInput(nome, scorta))
            return;

        //
        if (TryGetProduct(nome, out Prodotto? prodotto))
        {
            if (prodotto != null)
            {
                Console.WriteLine("Aumentata scorta di " + nome);
                prodotto.scorta += scorta;
            }
            else
            {
                prodotti.Add(new Prodotto(nome, scorta));
                Console.WriteLine("Prodotto " + nome + " aggiunto al magazzino");
            }
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

    private bool TryGetProduct(string nome, out Prodotto? product)
    {
        product = CercaProdotto(nome);
        if (product == null)
        {
            Console.WriteLine("Il prodotto " + nome + " non esiste");
            return false;
        }
        return true;
    }

    public void SetPrezzo(string nome, float prezzo)
    {
        if (TryGetProduct(nome, out Prodotto? prodotto))
        {
            if (prodotto != null)
            {
                prodotto.prezzo = prezzo;
            }
        }
    }

    public void RimuoviProdotto(string nome)
    {
        if (TryGetProduct(nome, out Prodotto? prodotto))
        {
            if (prodotto != null)
            {
                prodotti.RemoveAt(prodotti.IndexOf(prodotto));
            }
        }
    }

    public Prodotto? CercaProdotto(string nome)
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

    public int CercaIndiceProdotto(string nome)
    {
        if (TryGetProduct(nome, out Prodotto? prodotto))
            return prodotti.IndexOf(prodotto);

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