namespace AssignmentADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Excercise1
            ////1-create list
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            ////2-print list , count , first , last
            //Console.WriteLine("Before Sorting:");
            //Console.WriteLine( string.Join(",",grades));
            //Console.WriteLine($"Count:{grades.Count}");
            //Console.WriteLine($"first grade:{grades[0]}");
            //Console.WriteLine($"last grade:{grades[^1]}");

            ////3-sort list then print
            //grades.Sort();
            //Console.WriteLine("\nAfter Sorting:");
            //Console.WriteLine( string.Join(",",grades));

            ////4-first grade above 90
            //int firstGradeAbove90 =grades.Find(g => g > 90);
            //Console.WriteLine($"\nfirst grade above 90:{firstGradeAbove90}");

            ////5-get all grades below 75
            //List<int> failingGrades = grades.FindAll(g => g < 75);
            //Console.WriteLine($"\nfailing grades:{string.Join(",", failingGrades)}");

            ////6-remove failing grades
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine($"\ngrade list after removing:{string.Join(",", grades)}");

            ////7-check if any grade ==100
            //bool check = grades.Exists(g => g == 100);
            //Console.WriteLine($"\ncheck if any grade ==100:{check}");

            ////8-string grades list
            //List<string> stringGrades = new();
            //foreach (int grade in grades)
            //{
            //    stringGrades.Add($"Grade:{grade}");
            //}
            //Console.WriteLine($"\nstring grades:{string.Join(",", stringGrades)}");



            #endregion
        }
    }
}
