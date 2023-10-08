using System;
using System.IO;

public class Entry
{
    public string _date = "";
    public string _prommpt = "";
    public string _responsePrompt = "";

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return dateText;
    }

}