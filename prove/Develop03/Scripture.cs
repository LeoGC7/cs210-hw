public class Scripture
{
    //objects
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        char[] delimiters = new char[] {' ', ',', '.', '!', '?', ';'};
        foreach (string word in text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(word));
        }
    }

    //methods
    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsTheWordHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }

        if (CountVisibleWords() <= 2)
        {
            HideAllVisibleWords();
        }
    }

    public string ScriptureGetDisplayText()
    {
        string completeText = "";

        foreach (Word word in _words)
        {
            completeText = completeText + word.WordGetDisplayText() + " ";
        }

        return completeText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsTheWordHidden())
            {
                return false;
            }
        }
        return true;
    }

    private int CountVisibleWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsTheWordHidden())
            {
                count = count + 1;
            }
        }
        return count;
    }

    private void HideAllVisibleWords()
    {
        foreach (Word word in _words)
        {
            if (!word.IsTheWordHidden())
            {
                word.Hide();
            }
        }
    }

}