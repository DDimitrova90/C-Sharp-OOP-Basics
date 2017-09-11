namespace _04_Online_Radio_Database_1
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string Message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException() 
            : base(Message)
        {
        }

        public InvalidSongMinutesException(string message) 
            : base(message)
        {
        }
    }
}
