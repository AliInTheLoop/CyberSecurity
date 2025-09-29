namespace CyberSecCore.Cryptography;


public class Rot13 : ICipher
{
    public string Encrypt(string text)
    {
        var result = "";
        var c = 13;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                var a = (char)(((text[i] - 65 + c) % 26) + 65);
                result += a;
            }
            else if (char.IsLower(text[i]))
            {
                var b = (char)(((text[i]  - 97 + c ) % 26) + 97);
                result += b;
            }
            else
            {
                result += text[i];
            }
        }
        return result;
    }

    public  string Decrypt(string text)
    {
        var result = "";
        var c = -13;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                var a = (char)(((text[i] - 65 + c + 13) % 26) + 65);
                result += a;
            }
            else if (char.IsLower(text[i]))
            {
                var b = (char)(((text[i] - 97 + c + 26 + 13) % 26) + 97);
                result += b;
            }
            else
            {
                result += text[i];
            }
        }
        return result;
    }
}