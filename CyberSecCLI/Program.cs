using CyberSecCore.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            var cipher = Console.ReadLine()?.Trim();
            switch (cipher)
            {
                case "1":
                    CaesarCipherFunction("");
                    break;
                case "2":
                    Rot13CipherFunction("");
                    break;
            }

            continue;

            static void CaesarCipherFunction(string text)
            {
               Console.WriteLine("Type 'encrypt' to encrypt or 'decrypt' to decrypt or.");
               var input = Console.ReadLine();

               if (input == null) return;
               switch (input)
               {
                   case "encrypt":
                   {
                       Console.Write("Enter text to encrypt: ");
                       var inputText = Console.ReadLine();
                       var encrypt = CeasarCipher.Encrypt(inputText);
                       Console.WriteLine("Encrypt text: " + encrypt);
                       break;
                   }
                   case "decrypt":
                   {
                       Console.Write("Enter text to decrypt: ");
                       var inputDecrypt = Console.ReadLine();
                       var decrypt = CeasarCipher.Decrypt(inputDecrypt);
                       Console.WriteLine("Decrypt text " + decrypt);
                       break;
                   }
               }
               Console.WriteLine(text);
            }

            static void Rot13CipherFunction(string text)
            {
                Console.WriteLine("Type 'encrypt' to encrypt or 'decrypt' to decrypt or.");
                var input = Console.ReadLine();

                if (input == null) return;
                
                switch (input)
                {
                   case "encrypt":
                       Console.Write("Enter text to encrypt: ");
                       var inputText = Console.ReadLine();
                       var back = Rot13.EncryptRot13(inputText);
                       Console.WriteLine("Encrypt text: " + back);
                       break;
                   case "decrypt":
                       Console.Write("Enter text to encrypt: ");
                       var inputDecrypt = Console.ReadLine();
                       var backToNormal = Rot13.EncryptRot13(inputDecrypt);
                       Console.WriteLine("Encrypt text: " + backToNormal);
                       break;
                }
            }

            static void ShowMenu()
            {
                Console.WriteLine("Type the correspondent number to choice a cryptography!");
                Console.WriteLine("==Cryptography Menu==");
                Console.WriteLine("1. Caesar Cipher");
                Console.WriteLine("2. Rot13 Cipher");
            }
        }
    }
}