public class MyData
{
    [DictionaryKey("id")]
    public int Id{get;set;}

    [DictionaryKey("name")]
    public required string Name{get;set;}

    [DictionaryKey("desc")]
    public required string Description{get;set;}
}