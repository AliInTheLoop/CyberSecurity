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
                case "0":
                    Exit();
                    break;
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
               Console.WriteLine("Type 'encrypt' to encrypt or 'decrypt' to decrypt or 0 to exit.");
               var input = Console.ReadLine();

               if (input == null) return;
               switch (input)
               {
                   case "encrypt":
                   {
                       Console.Write("Enter text to encrypt: ");
                       var inputText = Console.ReadLine();
                       var encrypt = CeasarCipher.Encrypt(inputText);
                       Console.WriteLine("Encrypt text: " + "** " + encrypt + " **");
                       var decrypt = CeasarCipher.Decrypt(encrypt);
                       Console.WriteLine("Decrypt text: " + "** " + decrypt + " **");
                       break;
                   }
                   case "decrypt":
                   {
                       Console.Write("Enter text to decrypt: ");
                       var inputDecrypt = Console.ReadLine();
                       var encrypt = CeasarCipher.Encrypt(inputDecrypt);
                       Console.WriteLine("Decrypt text: " + "** " + encrypt +  " **");
                       var decryptCaesar = CeasarCipher.Decrypt(encrypt);
                       Console.WriteLine("Encrypt text: " +  "** " + decryptCaesar + " **");
                       break;
                   }
               }
               Console.WriteLine(text);
            }

            static void Rot13CipherFunction(string text)
            {
                Console.WriteLine("Type 'encrypt' to encrypt or 'decrypt' to decrypt or 0 to exit.");
                var input = Console.ReadLine();

                if (input == null) return;
                
                switch (input)
                {
                   case "encrypt":
                       Console.Write("Enter text to encrypt: ");
                       var inputText = Console.ReadLine();
                       var encryptRot13 = Rot13.EncryptRot13(inputText);
                       Console.WriteLine("Encrypt text: " + "** " +  encryptRot13 + " **");
                       var decryptRot13 = Rot13.EncryptRot13(encryptRot13);
                       Console.WriteLine("Decrypt text: " + "** " + decryptRot13 + " **");
                       break;
                   case "decrypt":
                       Console.Write("Enter text to encrypt: ");
                       var inputDecrypt = Console.ReadLine();
                       var decrypt = Rot13.DecryptRot13(inputDecrypt);
                       Console.WriteLine("Encrypt text: " + "** " + decrypt + " **");
                       var encrypt =  Rot13.EncryptRot13(inputDecrypt);
                       Console.WriteLine("Decrypt text: " + "** " + encrypt + " **");
                       break;
                }
                Console.WriteLine(text);
            }

            static void ShowMenu()
            {
                Console.WriteLine("Type the correspondent number to choice a cryptography!");
                Console.WriteLine("==Cryptography Menu==");
                Console.WriteLine("1. Caesar Cipher");
                Console.WriteLine("2. Rot13 Cipher");
                Console.WriteLine("0. Exit");
            }

            static void Exit()
            {
                Environment.Exit(0);
            }
        }
    }
}