using KataMoney;

namespace KataMoneyTest;

public class MoneyyTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(0,"No money")] //Lower bound
    [TestCase(5.47, "1 £5\n2 20p\n1 5p\n1 2p\n")] // Equivalence Partition
    [TestCase(21474836.47, "429496 £50\n1 £20\n1 £10\n1 £5\n1 £1\n2 20p\n1 5p\n1 2p\n")] //Upper bound
    public void GivenDouble_GetMoney_ReturnsBillsAndCoins(double amount, string expectedResult)
    {
        string result = Moneyy.GetMoney(amount);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GivenInvalidDouble_GetMoney_ThrowsException()
    {
        Assert.That(() => Moneyy.GetMoney(-9.32), Throws.InstanceOf<ArgumentOutOfRangeException>().With.Message.Contains("Can't have negative money!"));
    }

    [Test]

    public void GivenTooLargeDouble_GetMoney_ThrowsOverflowException()
    {
        Assert.That(() => Moneyy.GetMoney(21474836.48), Throws.InstanceOf<OverflowException>());
    }
}