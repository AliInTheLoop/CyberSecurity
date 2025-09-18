using NUnit.Framework;
using CyberSecCore.Cryptography;

namespace CyberSecCore.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void EncryptShouldShiftLettersByThree()
    {
        var input = "ABC";
        var expected = "DEF";
        
        var result = CeasarCipher.Encrypt(input);
        
        Assert.That(expected, Is.Not.EqualTo(input));
    }
    
    [Test]
    public void DecryptShouldShiftLettersBackToNormal()
    {
        var input = "DEF";
        var expected = "ABC";
        
        var result = CeasarCipher.Decrypt(input);
        Assert.That(input, Is.Not.EqualTo(result));
    }

    
}