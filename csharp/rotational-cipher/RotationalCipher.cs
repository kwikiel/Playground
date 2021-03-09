using System;
using System.Collections.Generic;
using System.Linq;

public static class RotationalCipher
{

    private static List<char> letters = Enumerable.Range('a', 26).Select(x => (char)x).ToList();
    private static List<char> uppercase = Enumerable.Range('A', 26).Select(x => (char)x).ToList();

    public static string Rotate(string text, int shiftKey)
    {

        var _output = "";
        foreach (char i in text)
        {
            if (i == '.')
            {
                _output += '.'.ToString();
                continue;
            }
            if (i == ',')
            {
                _output += i.ToString();
                continue;
            }
            if (i == '!')
            {
                _output += i.ToString();
                continue;
            }
            if (i == '\'')
            {
                _output += '\''.ToString();
                continue;
            }
            if (i == ' ')
            {
                _output += ' '.ToString();
                continue;
            }
            if (Char.IsUpper(i))
            {
                _output += uppercase[(uppercase.IndexOf(i) + shiftKey) % 26].ToString();
                continue;
            }
            if (Char.IsDigit(i))
            {
                _output += i.ToString();
                continue;
            }
            _output += letters[(letters.IndexOf(i) + shiftKey) % 26].ToString();
        }
        return _output;
    }
}