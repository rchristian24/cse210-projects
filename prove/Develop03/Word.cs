using System;
public class Word
{
    private string _textWord;
    private Boolean _hideWord;

    public string GetTextWord()
    {
        return _textWord;
    }
    public void SetTextWord(string textWord)
    {
        _textWord = textWord;
    }
    public Boolean GetHideWord()
    {
        return _hideWord;
    }
    public void SetHideWord()
    {
        _hideWord = true;
    }
    public Word(string textWord)
    {
        _textWord = textWord;
        _hideWord = false;
    }
    public Word()
    {
        _textWord = "";
        _hideWord = false;
    }
    public void DisplayWord()
    {
        if (_hideWord == false)
        {
            Console.Write($"{_textWord} ");
        }
        else
        {
            Console.Write(new string('_', _textWord.Count()));
            Console.Write(" ");
        }
    }
    public Boolean IsWordHidden()
    {
        return _hideWord;
    }
}