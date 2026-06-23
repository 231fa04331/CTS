using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerComm.Tests;

[TestFixture]
public class CustomerCommTests
{
    private Mock<IMailSender> _mailSenderMock = null!;
    private CustomerCommLib.CustomerComm _customerComm = null!;

    [OneTimeSetUp]
    public void Init()
    {
        _mailSenderMock = new Mock<IMailSender>();
        _mailSenderMock
            .Setup(mailSender => mailSender.SendMail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        _customerComm = new CustomerCommLib.CustomerComm(_mailSenderMock.Object);
    }

    [TestCase("cust123@abc.com", "Some Message")]
    public void SendMailToCustomer_ShouldReturnTrue(string expectedAddress, string expectedMessage)
    {
        var result = _customerComm.SendMailToCustomer();

        Assert.That(result, Is.True);
        _mailSenderMock.Verify(mailSender => mailSender.SendMail(expectedAddress, expectedMessage), Times.Once);
    }
}