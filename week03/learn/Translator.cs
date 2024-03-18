public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("vehicle", "la voiture");
        englishToGerman.AddWord("building", "le batiment");
        englishToGerman.AddWord("child", "l'enfant(e)");
        Console.WriteLine(englishToGerman.Translate("vehicle")); // Auto
        Console.WriteLine(englishToGerman.Translate("building")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("child")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        // ADD YOUR CODE HERE
        _words.Add(fromWord, toWord);

    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    /// 
    public string Translate(string fromWord)
    {
        // ADDt YOUR CODE HERE
        string questMark = "????";
        if(_words.ContainsKey(fromWord))
        {
            questMark = _words[fromWord];
        }


        return questMark;
    }
}