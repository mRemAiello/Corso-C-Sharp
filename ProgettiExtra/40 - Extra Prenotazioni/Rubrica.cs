public class Rubrica
{
    public delegate void GestioneContattoDelegate(Contatto contatto);

    public GestioneContattoDelegate OnContattoAggiunto;
    public GestioneContattoDelegate OnContattoRimosso;

    private List<Contatto> contatti;

    public Rubrica()
    {
        contatti = [];
    }

    public void AggiungiContatto(Contatto contatto)
    {
        contatti.Add(contatto);
        //OnContattoAggiunto?.Invoke(contatto);
        Observer observer = new Observer();
        observer.Invoke("Aggiunto", contatto);
    }

    public void RimuoviContatto(Contatto contatto)
    {
        contatti.Remove(contatto);
        OnContattoRimosso?.Invoke(contatto);
    }

    public List<Contatto> CercaContatti(string nome)
    {
        return contatti.Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Contatto> GetAllContatti()
    {
        return new List<Contatto>(contatti);
    }
}