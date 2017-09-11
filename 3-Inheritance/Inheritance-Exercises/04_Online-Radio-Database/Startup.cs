namespace _04_Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int songsNumber = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split(new char[] { ';' },
                    StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string artistName = songInfo[0];
                    string songName = songInfo[1];
                    string[] lenghtInfo = songInfo[2]
                        .Split(new char[] { ':' },
                        StringSplitOptions.RemoveEmptyEntries);

                    int minutes = 0;
                    int seconds = 0;

                    if (int.TryParse(lenghtInfo[0], out minutes) && int.TryParse(lenghtInfo[1], out seconds))
                    {
                        Song song = new Song(artistName, songName, minutes, seconds);
                        playlist.Add(song);
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid song length.");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            int length = playlist.Sum(s => s.Length);
            int hours = length / 60 / 60;
            int mins = (length - (hours * 60 * 60)) / 60;
            int secs = length - (hours * 60 * 60) - (mins * 60);

            Console.WriteLine($"Songs added: {playlist.Count()}");
            Console.WriteLine($"Playlist length: {hours}h {mins}m {secs}s");
        }
    }
}
