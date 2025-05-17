//using SchoolManagement;

using SchoolManagement;

public class Program
{
    public static void Main(string[] args)
    {
        //Person nesnesinden oluşturulan öğrenci ve öğretmenler
        Person student1 = new Person();
        student1.Name = "Hale";
        student1.Surname = "Kaya";
        student1.BirthDate = new DateTime(2000, 10, 14);

        Person student2 = new Person();
        student2.Name = "Ömer";
        student2.Surname = "Karlı";
        student2.BirthDate = new DateTime(1995, 04, 05);

        Person teacher1 = new Person();
        teacher1.Name = "Kadir";
        teacher1.Surname = "Aram";
        teacher1.BirthDate = new DateTime(1990, 06, 22);

        Person teacher2 = new Person();
        teacher2.Name = "Musa";
        teacher2.Surname = "Aydın";
        teacher2.BirthDate = new DateTime(1992, 01, 01);

        Console.WriteLine("Öğrenci: " + student1.Name + " " + student1.Surname + " , " + "Doğum tarihi: " + student1.BirthDate.ToShortDateString());
        Console.WriteLine("Öğrenci: " + student2.Name + " " + student2.Surname + " , " + "Doğum tarihi: " + student2.BirthDate.ToShortDateString());
        Console.WriteLine("Öğretmen: " + teacher1.Name + " " + teacher1.Surname + " , " + "Doğum tarihi: " + teacher1.BirthDate.ToShortDateString());
        Console.WriteLine("Öğretmen: " + teacher2.Name + " " + teacher2.Surname + " , " + "Doğum tarihi: " + teacher2.BirthDate.ToShortDateString());


    }
}