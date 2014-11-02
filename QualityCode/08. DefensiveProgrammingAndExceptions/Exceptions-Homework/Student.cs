using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public IList<Exam> Exams { get; private set; }

    public Student(string firstName, string lastName, IList<Exam> exams)
    {
        if (firstName == null)
        {
            throw new ArgumentNullException("firstName", "Student's first name cannot be null");
        }

        if (lastName == null)
        {
            throw new ArgumentNullException("lastName", "Student's last name cannot be null");
        }

        if (exams == null)
        {
            throw new ArgumentNullException("exams", "Exams cannot be null");
        }

        if (exams.Count == 0)
        {
            throw new ArgumentException("exams", "Exams can't be an empty IList<Exam>");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
