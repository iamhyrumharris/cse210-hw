public class Word
{
    //Attributes
    private string _originalText;
    private string _hiddenText;
    private bool _isHidden;

    //Constructors
    //Initializes the Word with the text. And then sets the lenth of the word to underscores for the hidden text.
    public Word(string text)
    {
        _originalText = text;
        int wordLength = _originalText.Length;
        _hiddenText = new string('_', wordLength);
        _isHidden = false;
    }

    //Methods
    //Hide will set the word to hidden.
    public void Hide()
    {
        _isHidden = true;
    }

    //Not really used but will show the word again if needed.
    public void Show()
    {
        _isHidden = false;
    }

    //Is the word hidden? This will let you know by returning true or false.
    public bool IsHidden()
    {
        return _isHidden;
    }

    //Determines if the word should be returned as the underscores or the original word.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return _hiddenText;
        }
        else
        {
            return _originalText;
        }
    }
}