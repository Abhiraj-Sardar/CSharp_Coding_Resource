using System.Collections.Generic;
using System.Data.Common;
Dictionary<string, int> dict = new Dictionary<string, int>()
{
    {"one", 1}, // "one" is the key, 1 is its associated value.
    {"two", 2}
};

dict.Add("id", 10); // Add a new item to the dictionary.
Console.WriteLine(dict["id"]);  // 10
Console.WriteLine(dict["one"]); // 1
Console.WriteLine(dict["two"]); // 2