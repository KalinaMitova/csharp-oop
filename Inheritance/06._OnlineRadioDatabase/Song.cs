using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._OnlineRadioDatabase
{
    public class Song
    {
        private string songName;
        private string artistName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string SongName
        {
            get
            { return this.songName;}
            private set
            {
                if (value.Length > 30 || value.Length < 3)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public string ArtistName
        {
            get
            { return this.artistName;}

            private set
            {
                if (value.Length > 20 || value.Length < 3)
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

    public int Minutes
    {
        get { return this.minutes;}

        private set
        {
           if (value > 14 || value < 0)
           {
               throw new InvalidSongMinutesException();
           }
           
           this.minutes = value;
        }
    }

        public int Seconds
        {
            get { return this.seconds; }

            private set
            {             
                if (value > 59 || value < 0)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }
    }
}
