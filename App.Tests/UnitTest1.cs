namespace App.Tests;

using App;

public class UnitTest1
{
    [Fact]
    public void Creates_WordGeneratorObject()
    {
        string FileName = Path.Combine("..", "..", "..", "..", "words.txt");
        App.WordGenerator wg = WordGenerator.Create(FileName);
        Assert.NotEqual(wg, null);
    }


    [Fact]
    public void WordGeneratorGeneratesWord()
    {
        string FileName = Path.Combine("..", "..", "..", "..", "words.txt");
        App.WordGenerator wg = WordGenerator.Create(FileName);
        string word = wg.Generate();
        Assert.NotEqual(word, null);
    }




}
