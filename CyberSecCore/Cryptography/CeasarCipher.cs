namespace CyberSecCore.Cryptography;

public class CeasarCipher
{
    public static string Encrypt(string text)
    {
        var result = "";
        var s = 3;

        for (int i =0;i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                var a = (char)(((text[i] - 65 + s) % 26) + 65);
                result += a.ToString();
            }
            else if (char.IsLower(text[i]))
            {
                var b = (char)(((text[i] - 97 + s) % 26) + 97);
                result += b.ToString();
            }
            else
            {
                result += text[i];
            }
        }
        return result;
    }

    public static string Decrypt(string text)
    {
        var result = "";

        var s = -3;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                var a = (char)(((text[i] + s - 65) % 26) + 65);
                result += a;
            }
            else if (char.IsLower(text[i]))
            {
                var b = (char)(((text[i] + s  - 97 + 26) % 26) + 97);
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