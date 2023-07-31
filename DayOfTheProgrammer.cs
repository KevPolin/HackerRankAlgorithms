//HackerRank: DayOfTheProgrammer

//Marie invented a Time Machine and wants to test it by time-traveling to visit Russia on the Day of the Programmer (the 256th day of the year) 
//during a year in the inclusive range from 1700 to 2700.

//From 1700 to 1917, Russia's official calendar was the Julian calendar; since 1919 they used the Gregorian calendar system. 
//The transition from the Julian to Gregorian calendar system occurred in 1918, when the next day after January 31st was February 14th. 
//This means that in 1918, February 14th was the 32nd day of the year in Russia.

//In both calendar systems, February is the only month with a variable amount of days; it has 29 days during a leap year, and 28 days during all other years. 
//In the Julian calendar, leap years are divisible by 4; in the Gregorian calendar, leap years are either of the following:
//    - Divisible by 400.
//    - Divisible by 4 and not divisible by 100.

//Given a year, y, find the date of the 256th day of that year according to the official Russian calendar during that year. 
//Then print it in the format dd.mm.yyyy, where dd is the two-digit day, mm is the two-digit month, and yyyy is y.

//For example, the given year = 1984. 1984 is divisible by 4, so it is a leap year. The 256th day of a leap year after 1918 is September 12, so the answer is 12.09.1984.

class DayOfTheProgrammer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, DayOfTheProgrammer, with parameters: TBD ");

        //List<int> ar = new List<int> { 1, 2, 3, 4, 5, 6 };
        int year = 1800;

        Solution(year);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static void Solution(int year)
    {
        //256th Day
        var programmerDate = "";
        if (year >= 1919)
            programmerDate = GetProgrammerDateForGregorianCalendar(year);
        else if (year <= 1917)
        {
            programmerDate = GetProgrammerDateForJulianCalendar(year);
        }
        else
        {
            //gregorian switch year
            programmerDate = "26.09.1918";// GetProgrammerDateForCalendarSwitchYear1918(year);
        }

        //return programmerDate;
        Console.WriteLine("Results: {0}", programmerDate);
    }

    private static string GetProgrammerDateForCalendarSwitchYear1918(int year)
    {
        //1918 was a gregorian calendar after 1918 (it wasn't a leap year)
        var daysTillAug = 230;//  31 + 15 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;
        programmerDateInSeptember = 256 - daysTillAug;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static string GetProgrammerDateForJulianCalendar(int year)
    {
        var daysTillAugInLeapYear = 244; //31 + 29 + 31 + 30 + 31 + 30 + 31 + 31
        var daysTillAugInNonLeapYear = 243; //31 + 28 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;
        programmerDateInSeptember = IsJulianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugInNonLeapYear;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static bool IsJulianLeapYear(int year)
    {
        if (year % 4 == 0)
            return true;

        return false;
    }

    private static string GetProgrammerDateForGregorianCalendar(int year)
    {
        var daysTillAugInLeapYear = 244; //31 + 29 + 31 + 30 + 31 + 30 + 31 + 31
        var daysTillAugInNonLeapYear = 243; //31 + 28 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;

        programmerDateInSeptember = IsGregorianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugInNonLeapYear;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static bool IsGregorianLeapYear(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;

        return false;
    }
}
