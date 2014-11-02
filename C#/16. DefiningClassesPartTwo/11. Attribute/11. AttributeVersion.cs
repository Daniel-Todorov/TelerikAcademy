//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
//and holds a version in the format major.minor (e.g. 2.11). 
//Apply the version attribute to a sample class and display its version at runtime.

using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
public class VersionAttribute : Attribute
{
    private int major;
    private int minor;
    private string version;

    public VersionAttribute(int major, int minor)
    {
        this.major = major;
        this.minor = minor;
        this.version = string.Format("{0}.{1}", major, minor);
    }

    public string Version
    {
        get
        {
            return this.version;
        }
    }
}

[VersionAttribute(1, 2)]
class Test
{
    static void Main()
    {
        Type type = typeof(Test);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute item in attributes)
        {
            Console.WriteLine("Version: {0}", item.Version);
        }
    }
}