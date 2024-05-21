public class Word
{
    //objects
    private string _text;
    private bool _isHidden;

    //constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsTheWordHidden()
    {
        return _isHidden;
    }

    public string WordGetDisplayText()
    {
        if(_isHidden)
        {
            return new string('_', _text.Length);
        }

        else
        {
            return _text;
        }
    }
}