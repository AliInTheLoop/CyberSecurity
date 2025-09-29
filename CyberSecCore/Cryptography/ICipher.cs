namespace CyberSecCore.Cryptography;


public interface ICipher
{
    string Encrypt(string input);
    string Decrypt(string input);
}