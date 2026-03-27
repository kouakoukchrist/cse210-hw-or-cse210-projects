using System;

public class Reception : Event
{
    private string _rsvpEmail;

public Reception(string rsvpEmail, string title, string description, string date, string time, Address address) : base( title,  description,  date,  time,  address)
    {
        _rsvpEmail = rsvpEmail;
    }
public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Event Type: {GetType().Name}\n Email: {_rsvpEmail}. ";
    }
}