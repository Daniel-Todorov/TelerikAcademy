using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Teacher : Person, IComment
    {
        List<Discipline> setOfDisciplines;

        public string Comment { get; set; }

        public List<Discipline> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            set
            {
                this.setOfDisciplines = value;
            }
        }

        public Teacher(string name, List<Discipline> setOfDisciplines)
            : base(name)
        {
            this.Name = name;
            this.setOfDisciplines = setOfDisciplines;
        }
    }
}
