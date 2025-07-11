public class Prodotto
{
    public string nome;
    public float prezzo;
    public int scorta;

    public Prodotto(string nome, int scorta)
    {
        this.nome = nome;
        this.scorta = scorta;
        prezzo = 0;
    }

    public void SetPrezzo(int prezzo)
    {
        this.prezzo = prezzo;
    }

    public override string ToString()
    {
        string ret = "Nome: " + nome + ", Prezzo: " + prezzo + ", Scorta: " + scorta;
        return ret;
    }
}