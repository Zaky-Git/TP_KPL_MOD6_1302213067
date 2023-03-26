using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length <= 100);
        Contract.Requires(title != null);
        this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;
  

    }

    public void increasePlayCount(int playCount)
    {
        Contract.Requires(playCount < 10000000);
        try
        {
            checked
            {
                this.playCount = playCount;
            }
        } catch (OverflowException ) {
            Console.WriteLine("Sudah sampai batas pemutaran");
        }
    }

    public void printVideoDetails()
    {
        Console.WriteLine("Video berjudul " + title + " diputar " + playCount + " kali dengan id video " + id);
    }
}

class main
{
    public static void Main(String[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Zaky Fathurahim");
        video1.printVideoDetails();

        Console.WriteLine();

        SayaTubeVideo video2 = new SayaTubeVideo("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
        video2.printVideoDetails();

        for (int i = 0; i < 10000001; i += 10000000)
        {
            video1.increasePlayCount(1000000);
        }

        video1.printVideoDetails();
    }
}