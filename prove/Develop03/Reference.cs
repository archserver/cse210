using System.Text;

public class Reference
{
    private int _book;
    private string _bookName;
    private int _chapterNumber;
    private int _startverse;
    private int _endverse;

    public Reference(int book, int chapterNumber, int startVerse)
    {
        SetReferenceBook(book);
        SetReferenceChapter(chapterNumber);
        SetVerseNumbers(startVerse, startVerse);
    }

    public Reference(int book, int chapterNumber, int startVerse, int endVerse)
    {
        SetReferenceBook(book);
        SetReferenceChapter(chapterNumber);
        SetVerseNumbers(startVerse, endVerse);
    }

    public int GetReferenceBook()
    {
        return _book;
    }

    public string GetReferenceBookName()
    {
        return _bookName;
    }

    public int GetReferenceChapter()
    {
         return _chapterNumber; 
    }

    public string GetReferenceVerse()
    {
        string retstr;
        if (_startverse == _endverse)
        {
            retstr = _startverse+1.ToString();
        }
        else
        {
            retstr = (_startverse+1).ToString()+" : "+(_endverse+1).ToString();
        }

        return retstr;
    }

    private void SetReferenceBook (int book)
    {
        _book = book;
    
    }
    private void SetReferenceChapter (int chapterNumber)
    {
        _chapterNumber = chapterNumber;
    }

    private void SetVerseNumbers(int startVerse, int endVerse)
    {
        _startverse = startVerse;
        _endverse = endVerse;
    }

    public string GetDisplayText(List<Book> books)
    {

/*        List<Verse> newVerses = new List<Verse>();

        Book selectedBook = books[GetReferenceBook()-1];
        Chapter selectedChapter = selectedBook.GetChapters()[GetReferenceChapter()-1];
        for (int i = _startverse; i <= _endverse; i++)
        {
            Verse selectedverse = selectedChapter.GetVerses()[i];
            newVerses.Add(selectedverse);
            
        }
        return newVerses;*/

        _bookName = books[_book].GetName();

        StringBuilder _versesinString = new StringBuilder();

        Book selectedBook = books[GetReferenceBook()];
        Chapter selectedChapter = selectedBook.GetChapters()[GetReferenceChapter()];
        for (int i = _startverse;  i<= _endverse; i++)
        {
            Verse selectedVerse = selectedChapter.GetVerses()[i];
            _versesinString.AppendLine($"{selectedVerse.GetVerseNumber()}: {selectedVerse.GetVerseText()}");
        }
        return _versesinString.ToString();
    }
}
