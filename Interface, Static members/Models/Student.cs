using Interface__Static_members.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interface__Static_members.Models
{
    internal class Student : ICodeAcademy
    {  
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string CodeEmail { get ; set ; }

        public static int Count = 0;
        public static string Capitalize(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        public static bool CheckName(string name, string surname)
        {
            string pattern = @"^[A-Z][a-z]{3,25}$";
           if(Regex.IsMatch(name, pattern) && Regex.IsMatch(surname, pattern))
            {
                return true;
            }
            else
            {
                return false;   
            }
           
        }
        public string GenerateEmail()
        {
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            return CodeEmail;
        }
        public Student(string name, string surname)
        {
           if(CheckName(name, surname))
            {
                Count++;
                Id = Count;
                Name = name ;
                Surname = surname ;
                Console.WriteLine(GenerateEmail());
                
            }
            else
            {
                Console.WriteLine("student doesn't created");
            }
        }

       
    }
    
}
