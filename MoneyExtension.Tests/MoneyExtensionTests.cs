namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShoulConvertDecimalToInt()
    {
        decimal value = 279.98M;
        var cents = value.ToCent();

        Assert.AreEqual(27998,cents);
    }
}