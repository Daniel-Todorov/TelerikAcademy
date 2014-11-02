//We are given a school. 
//In the school there are classes of students. 
//Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. 
//Students have name and unique class number. 
//Classes have unique text identifier. 
//Teachers have name. 
//Disciplines have name, number of lectures and number of exercises. 
//Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).

//Your task is to identify the classes (in terms of OPP) and their attributes and operations, 
//encapsulate their fields, 
//define the class hierarchy and 
//create a class diagram with Visual Studio.


//!!!NOTE!!! 
//I am not quite sure if I understood the task correctly. 
//If I didn't, please, write in the comments what I was supposed to do.
                                                  
using System;
using System.Collections.Generic;

namespace _01.School
{
    public class School
    {
        private List<Class> classes;

        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }

        public School(List<Class> classes)
        {
            this.classes = classes;
        }
    }
}
