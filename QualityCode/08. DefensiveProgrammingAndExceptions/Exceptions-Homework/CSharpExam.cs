﻿using System;

public class CSharpExam : Exam
{
    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("score", "Scores cannot have negative value");
        }
        if (score > 100)
        {
            throw new ArgumentOutOfRangeException("score", "Scores cannot be greater than 100");
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
