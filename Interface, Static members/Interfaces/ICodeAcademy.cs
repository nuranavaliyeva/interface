using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Static_members.Interfaces
{
    internal interface ICodeAcademy
    {
        public string CodeEmail { get; set; }
        public void GenerateEmail() 
        {
        }
    }
}
