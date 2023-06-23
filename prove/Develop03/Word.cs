public class Word
{
    private string _wordText;
    private bool _isVerseNumber = false;
    private bool _hiddenWord = false;

    public Word()
    {

    }

    public bool IsWordHidden()
    {
        return _hiddenWord;
    }
    public string Getword()
    {
        return _wordText;
    }

    public void SetWordText(string aword)
    {
        _wordText = aword;
    }

    public void HideWord()
    {
         _hiddenWord = true;
    }

    public void SetAsVerseNumber()
    {
        _isVerseNumber = true;
    }

    public bool IsVerseNumber()
    {
        return _isVerseNumber;
    }
}
