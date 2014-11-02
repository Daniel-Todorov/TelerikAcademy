using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade", "Grade can't be negative.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade", "MinGrade can't be negative.");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("MinGrade can't be greater or equal of maxGrade.");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentException("comments", "Comments can't be null or an empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
