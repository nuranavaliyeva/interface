using Interface__Static_members.Models;
using System.Security.Cryptography.X509Certificates;

namespace Interface__Static_members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("salam");
            Student student = new Student("Nurana","Valiyeva");
            Console.WriteLine("id: "+student.Id);
            Student student1 = new("Anar", "Valiyev");
            Console.WriteLine("id: "+student1.Id);
            Student student3 = new("123", "23435");
            group.AddStudent(student1);
            group.AddStudent(student);
            Group group1= new Group("Group A");


            group.GetGroupInfo();
            group1.GetGroupInfo();
            
            
            group.ShowStudents();
            Group.AddGroup(group1);
            Group.AddGroup(group);


            Group.ShowAllGroups();


        }
    }
}
