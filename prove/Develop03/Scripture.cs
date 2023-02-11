using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _verse;
    private Reference _reference;
    private List<Word> _wordList;

    public Scripture()
    {
        //default empty
        _verse = "";
        _reference = new Reference();
    }
    public Scripture(string verse)
    {
        //Proverbs verse without reference WORD TEXT
        _verse = verse;
        _reference = new Reference();
    }
    public Scripture(Reference reference, string verse)
    {
        _verse = verse;
        _reference = reference;
        string[] words = _verse.Split(' ');
        _wordList = WordList(words);
    }
    public void FullScripture()
    {
        _reference.DisplayReference();
        Console.WriteLine($" {_verse}");
    }
    public void TextDisplay()
    {
        _reference.DisplayReference();
        foreach (Word word in _wordList)
        {
            word.DisplayWord();
        }
        Console.WriteLine("");
    }
    public List<Word> WordList(string[] words)
    {
        List<Word> wordList = new List<Word>();
        foreach (string word in words)
        {
            Word obj = new Word(word);
            wordList.Add(obj);
        }
        return wordList;
    }
    public void HideRandomWord()
    {
        int counter = 0;
        while (counter < 3)
        {
            Random random = new Random();
            int index = random.Next(0, _wordList.Count());
            if (!_wordList.ElementAt(index).IsWordHidden())
            {
                _wordList.ElementAt(index).SetHideWord();
                counter++;
            }
        }
    }
    public Boolean IsVerseHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsWordHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void Test()
    {
        Console.WriteLine("Write the scripture (verse only, not reference): ");
        Console.Write(">");
        string test = Console.ReadLine();
        if (test == _verse)
        {
            Console.WriteLine("Woohoo! Great job!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying!");
        }
    }
}

