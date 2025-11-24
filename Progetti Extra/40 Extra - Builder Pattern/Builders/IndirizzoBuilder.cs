using ProgettiExtra.BuilderPattern.Models;

namespace ProgettiExtra.BuilderPattern.Builders;

public sealed class IndirizzoBuilder
{
    private string? _via;
    private string? _civico;
    private string? _citta;
    private string? _provincia;
    private string? _cap;

    public IndirizzoBuilder ConVia(string via)
    {
        _via = via;
        return this;
    }

    public IndirizzoBuilder ConCivico(string civico)
    {
        _civico = civico;
        return this;
    }

    public IndirizzoBuilder ConCitta(string citta)
    {
        _citta = citta;
        return this;
    }

    public IndirizzoBuilder ConProvincia(string provincia)
    {
        _provincia = provincia;
        return this;
    }

    public IndirizzoBuilder ConCap(string cap)
    {
        _cap = cap;
        return this;
    }

    public Indirizzo Build()
    {
        if (string.IsNullOrWhiteSpace(_via))
        {
            throw new InvalidOperationException("La via è obbligatoria.");
        }

        if (string.IsNullOrWhiteSpace(_civico))
        {
            throw new InvalidOperationException("Il civico è obbligatorio.");
        }

        if (string.IsNullOrWhiteSpace(_citta))
        {
            throw new InvalidOperationException("La città è obbligatoria.");
        }

        if (string.IsNullOrWhiteSpace(_provincia))
        {
            throw new InvalidOperationException("La provincia è obbligatoria.");
        }

        if (string.IsNullOrWhiteSpace(_cap))
        {
            throw new InvalidOperationException("Il CAP è obbligatorio.");
        }

        return new Indirizzo(_via.Trim(), _civico.Trim(), _citta.Trim(), _provincia.Trim(), _cap.Trim());
    }
}
