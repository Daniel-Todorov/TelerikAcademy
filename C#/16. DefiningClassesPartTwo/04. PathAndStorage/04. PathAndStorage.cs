//Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and load paths from a text file. 
//Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.IO;

public static class PathStorage
{
    public static void SavePath(Path path, string file)
    {
        StreamWriter writer = new StreamWriter(file);
        string lineToWrite = null;
        using (writer)
        {
            for (int a = 0; a < path.SequenceOfPoints.Count; a++)
            {
                lineToWrite = string.Format("{0} {1} {2}", path.SequenceOfPoints[a].X, path.SequenceOfPoints[a].Y, path.SequenceOfPoints[a].Z);
                writer.WriteLine(lineToWrite);
            }
        }
    }

    public static Path LoadPath(string file)
    {
        StreamReader reader = new StreamReader(file);
        Path result = new Path();
        Point3D point;
        string wholeText = null;
        string[] lines;
        string[] line;

        using (reader)
        {
            wholeText = reader.ReadToEnd();
            lines = wholeText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                line = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                point = new Point3D(int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]));
                result.SequenceOfPoints.Add(point);
            }
        }

        return result;
    }
}

public class Path
{
    public List<Point3D> SequenceOfPoints { get; set; }

    public Path()
    {
        this.SequenceOfPoints = new List<Point3D>();
    }
}

class Test
{
    public static void Main()
    {
        string file = "saved.txt";
        Point3D firstPoint = new Point3D(1, 2, 3);
        Point3D secondPoint = new Point3D(3, 1, -4);
        Path classPath = new Path();
        classPath.SequenceOfPoints.Add(firstPoint);
        classPath.SequenceOfPoints.Add(secondPoint);

        PathStorage.SavePath(classPath, file);
        Path newPath = PathStorage.LoadPath(file);
        newPath.SequenceOfPoints.Add(firstPoint);
        PathStorage.SavePath(newPath, file);
    }
}