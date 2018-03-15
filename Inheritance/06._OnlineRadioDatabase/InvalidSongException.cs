using System;

namespace _06._OnlineRadioDatabase
{
    internal class InvalidSongException : Exception
    {
        private const string Message = "Invalid song.";

        public InvalidSongException()
            :base(Message)
        {
        }

        public InvalidSongException(string message)
            :base(message)
        {
        }
    }
}
