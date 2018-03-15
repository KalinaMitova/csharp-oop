using System;
using System.Collections.Generic;

namespace _06._OnlineRadioDatabase
{
   public class OnlineRadioDatabase
    {
       public static void Main()
        {
            int numOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            int totalMinutes = 0;
            int totalSeconds = 0;

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] songData = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);              
                string artistName = songData[0];
                string songName = songData[1];
                string[] songLength = songData[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    int minutes = int.Parse(songLength[0]);
                    int seconds = int.Parse(songLength[1]);
                    Song song = new Song(artistName, songName, minutes, seconds);
                    totalMinutes +=  minutes;
                    totalSeconds += seconds;
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch(InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }
            totalMinutes = totalMinutes + totalSeconds / 60;
            totalSeconds = totalSeconds % 60;
            int totalHours = totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");

        }
    }
}
