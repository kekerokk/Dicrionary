using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicrionary
{
    internal class Student
    {
        public string Name,Familiya,Group;
        public int Age;

        public Student(string name, string familia, string group, int age)
        {
            Name = name;
            Familiya = familia;
            Group = group;
            Age = age;
        }

        public string toString()
        {
            return $"Имя:{Name}\nФамилия:{Familiya}\nГруппа:{Group}\nВозраст:{Age}\n";
        }
    }
}
