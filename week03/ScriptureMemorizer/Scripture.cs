public class Scripture
{
    // Attributes
    Reference _reference;
    List<Word> _words = new List<Word>();
    List<int> _randomWordNumbers = new List<int>();
    


    //Constructors
    //Initializes the Scripture with a Reference and text. Splits the text into word objects.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //Methods
    //Call to randomly hide 3 words. Sets the word to hidden. This will show underscores instead of the word.
    public void HideRandomWords()
    {
        var rand = new Random();
        int numHide = 3;
        int max = _words.Count();

        
        for (int i = 0; i < numHide; i++)
        {
            int randNum = rand.Next(0, max);
            if (_randomWordNumbers.Contains(randNum))
                {
                    i--;
                    continue;
                }
            _randomWordNumbers.Add(randNum);
            _words[_randomWordNumbers.Last()].Hide();
        }


    }

    public void ShowLastHiddenWords()
    {
        if (_randomWordNumbers.Count == 0)
        {
            return;
        }
        for (int i = 1; i < 4; i++)
        {
            _words[_randomWordNumbers.Last()].Show();
            _randomWordNumbers.RemoveAt(_randomWordNumbers.Count - 1);
        }
    }

    //This will return the string text of the scripture and any words that are hidden will show as underscores.
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + ": ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
        
    }

    //Will return true if all words are hidden.
    public bool IsCompletelyHidden()
    {
        if (_randomWordNumbers.Count == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}