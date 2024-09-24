using DelegateExample;
using EventExample;

public class Program
{
    static void Main(string[] args)
    {
        DelegateEx ex = new DelegateEx();
        ex.Execute();

        EventEx ex2 = new EventEx();
        ex2.Execute();
    }
}