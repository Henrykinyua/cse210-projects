public class Entry 
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    public void Format ()
    {
        Console.WriteLine($"Date: {_date} - prompt: {_prompt}\n{_response} ");
    }
}