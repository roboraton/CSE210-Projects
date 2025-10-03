public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    //Note from teacher ->     // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.

    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
    : base(studentName, topic)
    {
        // Note from teacher ->   // Here we set the MathAssignment specific variables
        _textBookSection = textBookSection;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }






}