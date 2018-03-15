using System;
namespace _06._OnlineRadioDatabase
{
   internal class InvalidSongLengthException : InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException()
            :base(Message)
        {
        }

        public InvalidSongLengthException(string message)
            :base(message)
        {
        }
    }
}
