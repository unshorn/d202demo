namespace App.Tests;

using App;

public class UnitTest1
{
    [Fact]
    public void Creates_WordGeneratorObject()
    {
        string FileName = "c:\\stuff\\d202demo\\words.txt";
        App.WordGenerator wg = WordGenerator.Create(FileName);
        Assert.NotEqual(wg, null);
    }




}