using System.Reflection.Metadata.Ecma335;

public class WrittinAssignment : Assignment
{
    private string _title;

    //Note from teacher ->     // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.

    public WrittinAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        // Note from teacher ->  // Here we set any variables specific to the WritingAssignment class

        _title = title;
    }

    public string GetWrittingInformation()
    {

        // Note from teacher -> // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}