bool IsCapital(string word)
{
    if (string.IsNullOrEmpty(word))
        return false; 

    if (word == word.ToUpper() || word == word.ToLower())
        return true;

    if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
        return true;

    return false;
}

string[] words = { "USA", "FlaG", "Google", "leetcode", "A","","b" };

foreach (var word in words)
{
    Console.WriteLine($"'{word}' -> {IsCapital(word)}");
}

Console.ReadKey();