using System;
					
public class Zrakoplov
{
    private string Naziv;
    private double SnagaMotora;
    private int DosegLeta;

    public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
    {
        Naziv = naziv;
        SnagaMotora = snagaMotora;
        DosegLeta = dosegLeta;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
        Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
        Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);
    }
}
// profesore uspio sam napraviti ali mi javlja warning skroz gore kod using system pa nisam siguran sto napraviti.