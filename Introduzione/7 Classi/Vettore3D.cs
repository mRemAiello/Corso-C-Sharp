public struct Vettore3D
{
    public double X;
    public double Y;
    public double Z;

    public Vettore3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Funzione()
    {
    }

    // Operatore di somma
    public static Vettore3D operator +(Vettore3D a, Vettore3D b)
    {
        return new Vettore3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Vettore3D operator -(Vettore3D a, Vettore3D b)
    {
        return new Vettore3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Vettore3D operator *(Vettore3D a, Vettore3D b)
    {
        return new Vettore3D(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public override string ToString()
    {
        return $"Vettore3D({X}, {Y}, {Z})";
    }
}


// Differenze tra struct e classe:

// Struct è passata per valore, una classe per riferimento.

// La struct viene allocata sullo stack, una classe sullo heap.
// Dato che si trovano sullo stack, quando diventano inutilizzate vengono automaticamente rimosse.
// Le classi, invece, hanno bisogno dell'intervento del garbage collector.

// La struct NON supporta l'ereditarietà.

// Per struct piccole le performance sono superiori.

// Non supportano i costruttori senza parametri, e neanche i distruttori.

// Non supportano il protected.