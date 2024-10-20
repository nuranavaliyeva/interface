using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Static_members.Models
{
    internal class Group
    {
        static Group[] Groups = new Group[0];
        static int GroupCount = 0;
        private int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student[] Students = new Student[0];
        public Group(string groupName)
        {

            GroupId = ++GroupCount;
            GroupName = groupName;

        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"Group Name: {GroupName}, Count: {GroupCount}");
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;


           
        }
        
        public static void AddGroup(Group groupName)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = groupName;
            


        }
     public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student: {student.Name} {student.Surname}, ID: {student.Id}, Email: {student.CodeEmail}");
            }
        }
        public static void ShowAllGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine($"{group.GroupName}");
            }
        }
    }
}
