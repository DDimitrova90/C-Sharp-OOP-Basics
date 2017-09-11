namespace _05_Date_Modifier
{
    using System;

    public class DateModifier
    {
        private long daysDifference;

        public long DaysDifference
        {
            get { return this.daysDifference; }
            set { this.daysDifference = value; }
        }

        public long CalculateDaysDifference(string firstDateStr, string secondDateStr)
        {
            DateTime firstDate = DateTime.Parse(firstDateStr);
            DateTime secondDate = DateTime.Parse(secondDateStr);

            TimeSpan daysDiff = firstDate - secondDate;
            return Math.Abs(daysDiff.Days);
        }
    }
}
