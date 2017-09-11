namespace _04_Online_Radio_Database_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int numberOfEntries = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ';' },
                    StringSplitOptions.RemoveEmptyEntries);

                string artistName = data[0];
                string songName = data[1];

                try
                {
                    int[] length = data[2]
                        .Split(new char[] { ':' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    int minutes = length[0];
                    int seconds = length[1];

                    Song song = new Song(artistName, songName, minutes, seconds);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            Console.WriteLine($"Songs added: {playlist.Count()}");

            int totalMinutes = playlist.Sum(s => s.Minutes);
            int totalSeconds = playlist.Sum(s => s.Seconds);
            totalSeconds += totalMinutes * 60;
            int finalMinutes = totalSeconds / 60;
            int finalSeconds = totalSeconds % 60;
            int finalHours = finalMinutes / 60;
            finalMinutes %= 60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");
        }
    }
}
