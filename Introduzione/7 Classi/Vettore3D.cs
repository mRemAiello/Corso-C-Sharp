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
        int a = 5;
        Vettore3D vettore1 = new Vettore3D(1, 2, 3);
        Vettore3D vettore2 = new Vettore3D(4, 5, 6);
        var vettore3 = vettore1 + vettore2; // Somma di vettori
        var vettore4 = a * vettore1;
    }

    // Operatore di somma
    public static Vettore3D operator *(Vettore3D a, int b)
    {
        return new Vettore3D(a.X * b, a.Y * b, a.Z * b);
    }

    public static Vettore3D operator *(int a, Vettore3D b)
    {
        return new Vettore3D(a * b.X, a * b.Y, a * b.Z);
    }

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

// Riferimento: persona -> 0x00002
// persona2 = persona -> 0x00002
// Vettore3D vettore -> 0x00003

// Struct è passata per valore, una classe per riferimento.

// La struct viene allocata sullo stack, una classe sullo heap.
// Dato che si trovano sullo stack, quando diventano inutilizzate vengono automaticamente rimosse.
// Le classi, invece, hanno bisogno dell'intervento del garbage collector.

// La struct NON supporta l'ereditarietà.

// Per struct piccole le performance sono superiori.

// Non supportano i costruttori senza parametri, e neanche i distruttori.

// Non supportano il protected.