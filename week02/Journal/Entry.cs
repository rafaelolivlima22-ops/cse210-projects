class Entry
{
   string _date;
   

   string _promptText;

   
   string _entryText;


   public Entry(string date, string promptText, string entryText)
   {
      _date = date;
      _promptText = promptText;
      _entryText = entryText;
   }

   public void Display()
   {
      Console.WriteLine($"Date: {_date}");
      Console.WriteLine($"Prompt: {_promptText}");
      Console.WriteLine($"Entry: {_entryText}");
   }
   
   public string GetDate()
   {
      return _date;
   }

    public string GetPromptText()
    {
        return _promptText;
    }

    public string GetEntryText()
    {
        return _entryText;
    }
}

