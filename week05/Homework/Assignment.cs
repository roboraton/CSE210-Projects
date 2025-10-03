using System.Runtime.InteropServices;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    // Note from the teacher ->    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSumary()
    {
        return _studentName + " - " + _topic;
    }







}