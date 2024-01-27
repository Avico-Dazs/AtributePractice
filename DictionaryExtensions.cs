using System.Reflection;

public static class DictionaryExtensions
{
    // オブジェクトのプロパティを連想配列に変換するメソッド
    public static Dictionary<string, object> ToDictionary(this object obj)
    {
        var dict = new Dictionary<string, object>();
        var properties = obj.GetType().GetProperties();

        foreach (var property in properties)
        {
            var attribute = property.GetCustomAttribute<DictionaryKeyAttribute>();
            if (attribute != null)
            {
                dict[attribute.Key] = property.GetValue(obj);
            }
        }

        return dict;
    }
}
