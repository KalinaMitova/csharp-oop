using System;

namespace _06._OnlineRadioDatabase
{
   internal class InvalidArtistNameException : InvalidSongException
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            :base(Message)
        {
        }

        public InvalidArtistNameException(string message)
            :base(message)
        {
        }
 
    }
}
