namespace CyberSecCore;


public interface ICipher
{
    string Encrypt(string input);
    string Decrypt(string input);
}