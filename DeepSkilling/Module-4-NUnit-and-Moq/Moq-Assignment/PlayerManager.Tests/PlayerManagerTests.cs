using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests;

[TestFixture]
public class PlayerManagerTests
{
    private Mock<IPlayerMapper> _playerMapperMock = null!;

    [OneTimeSetUp]
    public void Init()
    {
        _playerMapperMock = new Mock<IPlayerMapper>();
        _playerMapperMock
            .Setup(playerMapper => playerMapper.IsPlayerNameExistsInDb(It.IsAny<string>()))
            .Returns(false);
    }

    [TestCase("")]
    public void RegisterNewPlayer_EmptyName_ShouldThrowArgumentException(string name)
    {
        Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, _playerMapperMock.Object));
    }

    [TestCase("Virat Kohli")]
    public void RegisterNewPlayer_ValidName_ShouldReturnPlayer(string name)
    {
        var player = Player.RegisterNewPlayer(name, _playerMapperMock.Object);

        Assert.That(player.Name, Is.EqualTo(name));
        Assert.That(player.Age, Is.EqualTo(23));
        Assert.That(player.Country, Is.EqualTo("India"));
        Assert.That(player.NoOfMatches, Is.EqualTo(30));
        _playerMapperMock.Verify(playerMapper => playerMapper.AddNewPlayerIntoDb(name), Times.Once);
    }
}