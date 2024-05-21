public class Reference {
    
    //objects
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int verse) : this(book, chapter, verse, verse) {}

    //methods
    public string ReferenceGetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}