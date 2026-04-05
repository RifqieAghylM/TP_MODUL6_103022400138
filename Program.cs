class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Ghost - Justin Bieber");
        lagu1.PrintTrackDetails();

        Console.WriteLine("Menambahkan 500.000 play...");
        lagu1.increasePlayCount(500000);
        lagu1.PrintTrackDetails();

        Console.WriteLine("\nSimulasi pengujian Overflow...");
        try
        {
            for (int i = 0; i < 300; i++)
            {
                lagu1.increasePlayCount(10000000);
            }
        }

        catch (Exception)
        {

        }
        lagu1.PrintTrackDetails();
    }
}