// Using Stacks and Queues

// Create a New Playlist
Queue<string> playlist = new Queue<string>();

Console.WriteLine("Choose an option:");
Console.WriteLine("1.Add a song to your playlist");
Console.WriteLine("2. Play the next song in your playlist");
Console.WriteLine("3. Skip the next song");
Console.WriteLine("4. Rewind one song");
Console.WriteLine("5. Exit");

int chooseOpcion = int.Parse(Console.ReadLine());

if (chooseOpcion  == 1)
{
    Console.WriteLine("How Many Song do you want to add");
    int numSongsadd = int.Parse(Console.ReadLine());

    for (int i = 0; i < numSongsadd; i++)
    {
        Console.WriteLine("Enter Song Name:");
        string song = Console.ReadLine();
        playlist.Enqueue(song);
        Console.WriteLine($"{song} added to your playlist.");
    }    
}

Console.WriteLine("list of reproduction: "); 
foreach (string song in playlist)
{
    Console.WriteLine(song);
}
