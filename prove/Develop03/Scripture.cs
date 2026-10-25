public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitter = text.Split(" ");
        foreach (string word in splitter)
        {
            _words.Add(new Word(word));
        }
    }
    public string GetDisplayText()
    // Get the text combined so that it is "reference" + "verse of words"
    {
        string result = _reference.Display() + " ";
        // Grab all the words and iterate them in a for loop and add them to a new string (split them by spaces in between)
        foreach (Word word in _words)
        {
            result += word.Display() + " ";
        }
        return result;
    }
    public void HideRandomWords(int amountWordsToHide)
    // Randomly hide words by using a do while loop
    {
        Random random = new Random();
        for (int i = 0; i < amountWordsToHide; i++)
        {
            List<Word> seeWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    seeWords.Add(word);
                }
            }
            if (seeWords.Count == 0)
            {
                return;
            }
            int index = random.Next(seeWords.Count);
            seeWords[index].Hide();
        }
    }
    public bool IsEntirelyHidden()
    // Returns if the string is fully hidden or not
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}