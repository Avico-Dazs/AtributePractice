[AttributeUsage(AttributeTargets.Property)]
public class DictionaryKeyAttribute : Attribute
{
    public string Key { get; private set; }

    public DictionaryKeyAttribute(string key)
    {
        Key = key;
    }
}