namespace _04_Online_Radio_Database_1
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException() 
            : base(Message)
        {
        }

        public InvalidSongLengthException(string message) 
            : base(message)
        {
        }
    }
}
