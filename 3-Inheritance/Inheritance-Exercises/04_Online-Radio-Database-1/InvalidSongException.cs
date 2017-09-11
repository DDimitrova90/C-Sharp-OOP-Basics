namespace _04_Online_Radio_Database_1
{
    using System;

    public class InvalidSongException : Exception
    {
        private const string Message = "Invalid song.";

        public InvalidSongException()
            : base(Message)
        {
        }

        public InvalidSongException(string message)
            : base(message)
        {
        }
    }
}
