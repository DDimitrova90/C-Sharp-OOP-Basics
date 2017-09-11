namespace _04_Online_Radio_Database
{
    using System;

    public class Song
    {
        private string atistName;
        private string name;
        private int minutes;
        private int seconds;
        private int length;

        public Song(string artistName, string name, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get { return this.atistName; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid song.");
                }

                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }

                this.atistName = value;
            }
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid song.");
                }

                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }

                this.name = value;
            }
        }

        public int Length
        {
            get { return this.length = (this.minutes * 60) + this.seconds; }
        }

        public int Minutes
        {
            get { return this.minutes; }

            private set
            {
                if (string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Invalid song.");
                }

                if (value < 0 || value > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }

            private set
            {
                if (string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Invalid song.");
                }

                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }

                this.seconds = value;
            }
        }
    }
}
