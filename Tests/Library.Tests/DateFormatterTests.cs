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

    [Test]
    public void TestFechaEnBlanco()
    {
        const string input = "";
        const string expected = "";
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

     /*[Test]
    public void TestFechaCorrecta()
    {
        const string input = "30/07/2000";
        const string expected = "2000-07-30";
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    } */
}