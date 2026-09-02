using System.Threading.Tasks.Sources;

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
            #region Exercise2
            ////1-build leaderBoard dictionary
            //SortedDictionary<int, string> leaderBoard = new SortedDictionary<int, string>();
            //leaderBoard.Add(500, "Ahmed");
            //leaderBoard.Add(200, "Sara");
            //leaderBoard.Add(800, "Ali");
            //leaderBoard.Add(350, "Mona");

            ////2-print leadboard
            //Console.WriteLine("leader board:");
            //foreach (KeyValuePair<int,string> entry in leaderBoard)
            //{
            //    Console.WriteLine(entry);
            //}

            ////3-access first key and first value
            //int firstKey = leaderBoard.Keys.First();   
            //string firstValue = leaderBoard.Values.First();
            //Console.WriteLine($"\nfirst key:{firstKey}--first value:{firstValue}");

            ////4-check if score 500 exists
            //Console.WriteLine($"\nscore 500 exists: {leaderBoard.ContainsKey(500)}");

            ////5-safely get player of score 999
            //bool scoreExists = leaderBoard.TryGetValue(999, out string? player);
            //Console.WriteLine($"\nscore 999 exist: {scoreExists}"); 
            //Console.WriteLine($"player of score 999: {player??"Null"}");

            ////6-remove player with score 200
            //leaderBoard.Remove(200);
            //Console.WriteLine("\nleader board after removing :");
            //foreach (KeyValuePair<int, string> entry in leaderBoard)
            //{
            //    Console.WriteLine(entry);
            //}
            #endregion
        }
    }
}
