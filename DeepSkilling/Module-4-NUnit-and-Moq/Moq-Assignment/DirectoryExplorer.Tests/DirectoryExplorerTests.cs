using MagicFilesLib;
using Moq;
using NUnit.Framework;

namespace DirectoryExplorer.Tests;

[TestFixture]
public class DirectoryExplorerTests
{
    private readonly string _file1 = "file.txt";
    private readonly string _file2 = "file2.txt";
    private Mock<IDirectoryExplorer> _directoryExplorerMock = null!;

    [OneTimeSetUp]
    public void Init()
    {
        _directoryExplorerMock = new Mock<IDirectoryExplorer>();
        _directoryExplorerMock
            .Setup(directoryExplorer => directoryExplorer.GetFiles(It.IsAny<string>()))
            .Returns(new[] { _file1, _file2 });
    }

    [TestCase("C:\\temp")]
    public void GetFiles_ShouldReturnTwoMockedFiles(string path)
    {
        var files = _directoryExplorerMock.Object.GetFiles(path);

        Assert.That(files, Is.Not.Null);
        Assert.That(files.Count, Is.EqualTo(2));
        Assert.That(files, Does.Contain(_file1));
    }
}