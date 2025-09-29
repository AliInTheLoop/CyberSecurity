using System.Net.Security;
using CyberSecCore.Cryptography;
using CyberSecCore;

class Program
{
    private static readonly ICipher CipherCaesar = new CaesarCipher();
    private static readonly ICipher CipherRot13 = new Rot13();
    
    
    static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            var cipher = Console.ReadLine()?.Trim();

            switch (cipher)
            {
                case "0":
                    Exit();
                    break;
                case "1":
                    CipherFunction(CipherCaesar);
                    break;
                case "2":
                    CipherFunction(CipherRot13);
                    break;
            }
        }
        return;
    }

    private static void CipherFunction(ICipher cipherText)
    {
        Console.WriteLine("Type 'encrypt' or 'decrypt': ");
        var input = Console.ReadLine();
        
        Console.WriteLine("Cipher Text: ");
        var cipher = Console.ReadLine();
        
        
        if (input == null) return;
        
        var result = input switch
        { 
            "encrypt" => cipherText.Encrypt(cipher), 
            "decrypt" => cipherText.Decrypt(cipher),
            _ => throw new ArgumentOutOfRangeException()
        };
        
        Console.WriteLine(result);
    }
    static void ShowMenu() 
    {
        Console.WriteLine("==Cryptography Menu==");
        Console.WriteLine("Type 1: Caesar Cipher");
        Console.WriteLine("Type 2: Rot13 Cipher");
        Console.WriteLine("0. Exit");
    }

    static void Exit() 
    { 
        Environment.Exit(0);
    }
}