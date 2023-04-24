using NUnit.Framework;
using TestDateFormat;
using System.Text;
namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFechaIncorrecta()
    {
        const string input = "50/50/5000";
        const string expected = "";
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}