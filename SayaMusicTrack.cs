using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul track tidak boleh null!");
        Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter!");

        this.title = title;

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.playCount = "0";
    }

    public void increasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000 per panggilan!");

        try
        {
            checked
            {
                int currentCount = int.Parse(this.playCount);
                int newCount = currentCount + count;
                this.playCount = newCount.ToString();
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow pada playCount (melebihi batas maksimal integer)!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("=== Track Details ===");
        Console.WriteLine($"ID         : {this.id}");
        Console.WriteLine($"Title      : {this.title}");
        Console.WriteLine($"Play Count : {this.playCount}");
        Console.WriteLine("---------------------");
    }
}