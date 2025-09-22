public class Observer
{
    public delegate void GestioneContattoDelegate(Contatto contatto);
    public GestioneContattoDelegate OnContattoAggiunto;
    public GestioneContattoDelegate OnContattoRimosso;

    public void Invoke(string action, Contatto contatto)
    {
        if (action == "Aggiunto")
        {
            OnContattoAggiunto?.Invoke(contatto);
        }
        else if (action == "Rimosso")
        {
            OnContattoRimosso?.Invoke(contatto);
        }
    }
}