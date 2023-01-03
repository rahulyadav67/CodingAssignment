using CodingAssignment1;

Console.WriteLine("Coding Assignment");
var students = new List<Student> {
new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Aishwarya",LastName="Verma",Age=19, Gender="F", TeamName="A" },

new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
};

Console.WriteLine("Answers:");
Console.WriteLine("1.");
var a = students.GroupBy(s => s.TeamName);
foreach (var x in a)
Console.WriteLine(x.Key + " : " + x.Count());

Console.WriteLine("\n2. All Male Students");
var MaleStudents = students.Where(s => s.Gender == "M");
PrintData.PrintA(MaleStudents);

Console.WriteLine("\n3. All FeMale Students");
var FemaleStudents = students.Where(s => s.Gender == "F");
PrintData.PrintA(FemaleStudents);

Console.WriteLine("\n4. All Male Students with age 20");
var AllMale = students.Where(s => (s.Gender == "M" && s.Age == 20));
PrintData.PrintA(AllMale);

Console.WriteLine("\n5. All FeMale Students with age 19");
var AllFemale = students.Where(s => (s.Gender == "F" && s.Age == 19));
PrintData.PrintA(AllFemale);

Console.WriteLine("\n6. All Students with FirstName A");
var FirstNameA = students.Where(s => s.FirstName.ToUpper().StartsWith("A"));
PrintData.PrintA(FirstNameA);

Console.WriteLine("\n7. All Students Whose LastName is Empty");
var EmptyLastName = students.Where(s => s.LastName == "");
PrintData.PrintA(EmptyLastName);

Console.WriteLine("\n8. First Two Students From Each Team");
var h = students.GroupBy(s => s.TeamName);
foreach (var x in h)
{
var y = x.Take(2);
Console.WriteLine("\nTeam: " + x.Key);
PrintData.PrintA(y);
}
Console.WriteLine("\n9. Student From 8th to 17th Position");
//var studentss = students.Skip(7).Take(10);
var studentss = students.GetRange(7, 10);
PrintData.PrintA(studentss);

Console.WriteLine("\n10. All Students FirstName With Age");
var j = students.Select(s => new { s.FirstName, s.Age });
foreach (var x in j)
Console.WriteLine(x);

Console.WriteLine("\n******************** Integer Array **************************");
var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8 };

Console.Write("11.Unique Element:");
var n1 = numbers.GroupBy(n => n).Where(n => n.Count() == 1);
foreach (var x in n1)
Console.WriteLine(x.Key);

Console.WriteLine("\n12.Distinct Element:");
var n2 = numbers.Distinct();
foreach (var x in n2)
Console.Write(x + "  ");

Console.Write("\n\n13.Maximum Occured Element: ");
var n3 = numbers.GroupBy(n => n).OrderBy(n => n.Count()).Last().Key;
Console.WriteLine(n3);

var n4 = numbers.GroupBy(n => n).OrderBy(n => n.Count()).First().Key;
Console.WriteLine("\n14.Minimum Occured Element: " + n4);

Console.WriteLine("\n15.Even Numbers:");
var n5 = numbers.Where(n => (n % 2 == 0));
foreach (var x in n5)
Console.Write(x + "  ");
Console.WriteLine("\nOdd Numbers:");
var n6 = numbers.Where(n => (n % 2 != 0));
foreach (var x in n6)
Console.Write(x + "  ");

public class PrintData
{
    public static void PrintA(IEnumerable<Student> students)
    {
        foreach (var student in students)
            student.Print();

    }

}
