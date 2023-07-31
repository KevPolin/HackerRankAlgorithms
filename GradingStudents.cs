//HackerRank: GradingStudents

//HackerLand University has the following grading policy:
//Every student receives a  in the inclusive range from  to .
//Any  less than  is a failing grade.
//Sam is a professor at the university and likes to round each student's  according to these rules:

//If the difference between the  and the next multiple of  is less than , round  up to the next multiple of .
//If the value of  is less than , no rounding occurs as the result will still be a failing grade.
//Examples

// round to  (85 - 84 is less than 3)
// do not round(result is less than 40)
// do not round(60 - 57 is 3 or higher)
//Given the initial value of  for each of Sam's  students, write code to automate the rounding process.

class GradingStudents
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, GradingStudents, with parameters: 73 67 38 33 ");

        List<int> ints = new List<int> { 73, 67, 38, 33 };

        Solution(ints);

        Console.WriteLine("Finished running project");
    }

    public static void Solution(List<int> grades)
    {
        var results = new int[grades.Count];

        for (var i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                for (var j = 0; j < 5; j++)
                {
                    if ((grades[i] + j) % 5 == 0)
                    {
                        var rounded = (grades[i] + j);
                        if (j >= 3)
                        {
                            results[i] = grades[i];
                        }
                        else
                        {
                            results[i] = rounded;
                        }
                    }
                }
            }
            else
            {
                results[i] = grades[i];
            }
        }

        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine("Result " + i + " " + results[i] + " ");
        }
    }
}