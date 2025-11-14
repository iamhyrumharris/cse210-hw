public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    //Constructors
    //Initializes the Reference with book chapter and verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //Initializes the Reference with book chapter and verse range.
    public Reference(string book, int chapter, int versesStart, int versesEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = versesStart;
        _verseEnd = versesEnd; 
    }

    //Methods
    //Returns the string of the reference.
    public string GetDisplayText()
    {
        if (_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}