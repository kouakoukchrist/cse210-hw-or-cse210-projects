


using System;

public class WritingAssignment : Assigment
{
    private string _text = "";
   


   public WritingAssignment(string studentName, string topic ,string text ) : base(studentName,  topic)
    {
        _text = text;
        
    }

    public string GetWritingInformation()

    {
        string studentName = GetStudentName();

        return $"{_text} by {studentName}";
    }
}


