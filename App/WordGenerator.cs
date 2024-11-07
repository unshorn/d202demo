namespace App;

public class WordGenerator
{
    List<string> _words;
    Random _random;
    public WordGenerator()
    {


    }

    public static WordGenerator Create(string filename)
    {

        WordGenerator wordGenerator = new WordGenerator();
        wordGenerator._words = new List<string>(File.ReadAllLines(filename));
        wordGenerator._random = new Random();
        return wordGenerator;


    }

    public string Generate()
    {
        int index = _random.Next(0, _words.Count);
        return _words[index];

    }


}