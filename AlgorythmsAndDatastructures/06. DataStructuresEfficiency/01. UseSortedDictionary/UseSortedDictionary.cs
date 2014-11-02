//A text file students.txt holds information about 
//students and their courses.
//Using SortedDictionary<K,T> print the courses in 
//alphabetical order and for each of them prints the 
//students ordered by family and then by name.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class UseSortedDictionary
{
    private const string fileName = "students.txt";

    public static void Main()
    {
        var reader = new StreamReader(fileName);

        var dataLine = String.Empty;
        var recordsOfLanguages = new SortedDictionary<string, List<Student>>();

        using (reader)
        {
            while ((dataLine = reader.ReadLine()) != null)
            {
                string[] dataSet = dataLine.Split('|');

                string language = dataSet[2].Trim();
                string newStudentFirstName = dataSet[0].Trim();
                string newStudentLastName = dataSet[1].Trim();

                var newStudent = new Student(newStudentFirstName, newStudentLastName);

                if (!recordsOfLanguages.ContainsKey(language))
                {
                    recordsOfLanguages[language] = new List<Student>();
                }

                recordsOfLanguages[language].Add(newStudent);
            }
        }

        foreach (var language in recordsOfLanguages)
        {
            Console.Write("{0}: ", language.Key);

            var orderedStudents = language.Value.OrderBy(student => student.LastName).ThenBy(student => student.FirstName).ToList();
            int numberOfStudents = orderedStudents.Count;

            for (int j = 0; j < numberOfStudents; j++)
            {
                if (j < numberOfStudents - 1)
                {
                    Console.Write("{0} {1}, ", orderedStudents[j].FirstName, orderedStudents[j].LastName);
                }
                else
                {
                    Console.Write("{0} {1}", orderedStudents[j].FirstName, orderedStudents[j].LastName);
                }
            }

            Console.Write(Environment.NewLine);
        }
    }
}
