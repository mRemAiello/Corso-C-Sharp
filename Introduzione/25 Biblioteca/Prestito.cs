public class Prestito
{
    private Cliente _cliente;
    private Libro _libro;
    private Data _dataInizio;
    private Data _dataFine;

    // 
    public Prestito(Cliente cliente, Libro libro)
    {
        _cliente = cliente;
        _libro = libro;
        _dataInizio = new(27, 8, 2025);
        _dataFine = new(27, 8, 2025);
    }

    //
    public Cliente GetCliente() => _cliente;
    public Libro GetLibro() => _libro;
    public Data GetDataInizio() => _dataInizio;
    public Data GetDataFine() => _dataFine;
    public void SetDataFine(Data dataFine) => _dataFine = dataFine;

    //
    public override string ToString()
    {
        string ret = $"L'utente {_cliente.GetID()} ha in prestito {_libro.GetTitolo()} con ISBN {_libro.GetISBN()}";
        ret += $", preso in prestito in data {_dataInizio} e da restituire in {_dataFine}";
        return ret;
    }
}