//HackerRank: TimeConversion

//Given a time in -hour AM/PM format, convert it to military (24-hour) time.
//Note: -12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
// - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
// Example
//s = '12:01:00PM' - Return '12:01:00'.
//s = '12:01:00AM' - Return '00:01:00'.

class TimeConversion
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, TimeConversion, with parameters: '12:01:00AM' ");

        string timeInAMPM = "12:01:00AM";

        Solution(timeInAMPM);

        Console.WriteLine("Finished running project");
    }

    public static void Solution(string s)
    {
        var amOrPm = s.Substring(8);
        var hourComponent = s.Substring(0, 2);
        var remainingTimeComponent = s.Substring(2, 6);
        if (amOrPm == "AM" && hourComponent == "12")
        {
            hourComponent = "00";
        }
        else if (amOrPm == "PM")
        {
            var numericHourComponent = int.Parse(hourComponent);
            if (numericHourComponent != 12)
            {
                hourComponent = Convert.ToString(12 + numericHourComponent);
            }
        }
        Console.WriteLine(hourComponent + remainingTimeComponent);
    }
}