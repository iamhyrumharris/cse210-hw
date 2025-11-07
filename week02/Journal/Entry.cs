/*
Entry
Attributes
_date: String
_response: String
_prompt: String
Behaviors
Display(): void (String (Display the prompt, writeline))
*/


public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;

    public Entry(string date, string prompt, string response) //This will help with adding a new entry to the journal
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }
}