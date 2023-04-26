using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0421hw
{
    internal class Student
    {
        public string Name {  get; set; }
        public int Group { get; set; }
        public int PhysicsMark { get; set; }
        public int MathMark { get; set; }
        public int CompMark { get; set; }
        public DateTime LastExamPassed { get; set; }
        public Student(string name, int group, int physicsMark, int mathMark, int compMark, DateTime lastExamPassed)
        {
            Name = name;
            Group = group;
            PhysicsMark = physicsMark;
            MathMark = mathMark;
            CompMark = compMark;
            LastExamPassed = lastExamPassed;
        }
    }
}
