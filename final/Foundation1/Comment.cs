using System;

public class Comment
{
    public string _text;
    public string _name;

public Comment( string text, string name)
    {
        _text = text;
        _name = name ;
    }

    public string GetText()
    {
        return _text;
    }

    public string GetName()
    {
        return _name;
    }
}