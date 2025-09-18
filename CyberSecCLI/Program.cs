using CyberSecCore.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        CeasarCipherFunction("Testing to see if it works.");
        CeasarCipherFunction("zxyw");

        static void CeasarCipherFunction(string text)
        {
            var encrypted = CeasarCipher.Encrypt(text);
            Console.WriteLine("Encrypted: " + encrypted);
            
            var decrypted = CeasarCipher.Decrypt(encrypted);
            Console.WriteLine("Decrypted: " + decrypted);
        }
    }
}