public class Scripture
{
    private  List<Word> _words;

    public Scripture(string theText)
    {
        _words = new List<Word>();
        // build the word list from the text
        
        string[] ArrayofWords = theText.Split(new[] {' ', '\r', '\n'},StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in ArrayofWords)
        {
            Word newWord = new Word();
            newWord.SetWordText(word);
            // If it is a verse number set the verse number flag
            if(word.Length > 1 && word.EndsWith(":"))
            {
                newWord.SetAsVerseNumber();
            }
            _words.Add(newWord);

        }
    }

    public void PrintTheVerse(Reference reference)
    {
        Console.Clear();


        Console.WriteLine($"{reference.GetReferenceBookName()} {reference.GetReferenceChapter()+1} {reference.GetReferenceVerse()}");

        foreach(Word word in _words)
        {
            if (word.IsVerseNumber())
            {
                // line break on any line marked as a verse numbers
                Console.WriteLine("");
                Console.Write($"{word.Getword()}");
                Console.Write(" ");
            }
            else
            {
                // hide any words that are marked hidden
                if(word.IsWordHidden())
                {
                    for (int i = 0; i < word.Getword().Length; i++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write($"{word.Getword()}");
                }
                Console.Write(" ");
            }
        }
        
    }

    public bool HideSomeWords()
    {
        int visablecount = GetNumberofVisableWords();
        bool finished = true;

        // check to see that not all are hidden
        if(visablecount>0)
        {
            finished = false;

            Random random = new Random();

            // randomly select words that are not already hidden and are not marked as a verse numbers
            int numberofWordstoHide = Math.Max(Math.Min(visablecount/3, 5 ),1);

            for(int i = 0; i < numberofWordstoHide; i++)
            {
                int randomselection = random.Next(_words.Count);
                Word wordtohide;

                do 
                {
                   randomselection = random.Next(_words.Count);
                   wordtohide = _words[randomselection];
                }while(wordtohide.IsVerseNumber() || wordtohide.IsWordHidden());

            //    Console.WriteLine($"hiding the word: {wordtohide.Getword()} is verse number = {wordtohide.IsVerseNumber()}, is hidden = {wordtohide.IsWordHidden()}");
                wordtohide.HideWord();
                
                
            }
            //Console.Write($"Total visable: {visablecount} Hiding count: {numberofWordstoHide}");
            //Console.ReadLine();
        }
        return finished;
    }

    public int GetNumberofVisableWords()
    {
        int visablewords = 0;
        // count the number of words which are not hidden and are not marked as a verse number
        foreach(Word word in _words)
        {
            if(!(word.IsVerseNumber() || word.IsWordHidden()))
            {
                visablewords++;
            }
        }

        return visablewords;

    }

}