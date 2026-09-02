using System.ComponentModel;
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
            #region Exercise3
            ////1-crrate phoneBook dictionary
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //phoneBook.Add("esraa", "01234567540");
            //phoneBook.Add("salma", "01123445564");
            //phoneBook.Add("rawan", "01034456611");
            //phoneBook.Add("rana", "01125567887");

            ////2-add new contact with[]/update exist contact
            //phoneBook["dina"] = "010045685432";
            //phoneBook["esraa"] = "01146919543";


            ////3-add duplicate key using add
            //try
            //{
            //    phoneBook.Add("esraa", "01018357520");

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"\nError: {ex.Message}");


            //}

            ////4-add duplicate key using TryAdd
            //bool isAdded = phoneBook.TryAdd("esraa", "01018357520");
            //Console.WriteLine($"\nAdding sucess:{isAdded}");

            ////5-search contact not exist
            //bool isExist = phoneBook.ContainsKey("khaled");
            //Console.WriteLine($"\ncontact exist:{isExist}");

            ////6-get contact with fallback not found
            //bool isFound = phoneBook.TryGetValue("toqa", out string? phoneNumber);
            //Console.WriteLine($"\ncontact found :{isFound}--phone number:{phoneNumber??"not found"}");

            ////7- print keys and values in separated lines
            //Console.WriteLine("\n");
            //Console.WriteLine($"keys:{string.Join(", ", phoneBook.Keys)}");
            //Console.WriteLine($"values:{string.Join(", ", phoneBook.Values)}");
            #endregion
            #region Excercise4
            ////1-create hashset (ignore uppercase)
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            ////2-add emails
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            ////3-count
            ////count should be 2 because HashSet ignores duplicates (case-insensitive)
            //Console.WriteLine($"count : {emails.Count}");//2

            ////4-set A& B
            //HashSet<int> A = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int>() { 4, 5, 6, 7, 8 };

            ////5-unionwith , intersectwith , exceptwith
            //HashSet<int> union = new HashSet<int>(A);
            //union.UnionWith(B);
            //Console.WriteLine($"\nunion:{string.Join(",", union)}");

            //HashSet<int> intersection = new HashSet<int>(A);
            //intersection.IntersectWith(B);
            //Console.WriteLine($"intersection:{string.Join(",", intersection)}");

            //HashSet<int> difference = new HashSet<int>(A);
            //difference.ExceptWith(B);
            //Console.WriteLine($"difference:{string.Join(",", difference)}");

            ////6-subset of
            //HashSet<int> isSubsetOf = new HashSet<int>() { 1, 2 };
            //Console.WriteLine($"IsSubset Of? : {isSubsetOf.IsSubsetOf(A)}");
            #endregion
            #region Excercise5
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");

            ////1-print queue and count 
            //Console.WriteLine($"document = [{string.Join(",",documents)}]");
            //Console.WriteLine($"count = {documents.Count}");

            ////2-peek
            //Console.WriteLine($"peek:{documents.Peek()}");

            ////3-dequeue each document then print
            //Console.WriteLine("\n dequeuing documents:");
            //while (documents.Count > 0) 
            //{
            //   string document = documents.Dequeue();
            //    Console.WriteLine($"printing : [{document}]");

            //}

            ////4-trydequeue on empty queue
            //bool isDequeued = documents.TryDequeue(out string? dequeuedDocument);
            //Console.WriteLine($"\ntry dequeue: {isDequeued}, document: {dequeuedDocument ?? "null"}");

            #endregion
        }

    }

}


