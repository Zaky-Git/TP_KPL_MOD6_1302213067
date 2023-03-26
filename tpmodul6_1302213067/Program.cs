class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        this.title = title;
        Random random = new Random();
        id = random.Next(10000,99999);
        playCount = 0;
    }

    public void increasePlayCount(int playCount)
    {
        this.playCount = playCount;
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
    }
}