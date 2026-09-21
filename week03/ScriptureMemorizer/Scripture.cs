using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

       
        string[] wordArray = text.Split(' ');
        foreach (string w in wordArray)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
       
        List<Word> hiddenCandidates = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && hiddenCandidates.Count > 0; i++)
        {
            int index = rand.Next(hiddenCandidates.Count);
            hiddenCandidates[index].Hide();
            hiddenCandidates.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}