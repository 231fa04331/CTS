# Moq Assignment

This folder contains the mock-based exercises from the module.

## What is here

- [CustomerCommLib](CustomerCommLib)
- [CustomerComm.Tests](CustomerComm.Tests)
- [MagicFilesLib](MagicFilesLib)
- [DirectoryExplorer.Tests](DirectoryExplorer.Tests)
- [PlayersManagerLib](PlayersManagerLib)
- [PlayerManager.Tests](PlayerManager.Tests)

## What it does

Each test project uses NUnit and Moq to isolate the code under test from external dependencies:

- SMTP mail sending
- file system access
- SQL database access

## Run command

Use `dotnet test` on the matching `.csproj` file, for example:

```powershell
& "C:\Program Files\dotnet\dotnet.exe" test "c:\Users\Lenovo\Desktop\CTS_repo\DeepSkilling\Module-4-NUnit-and-Moq\Moq-Assignment\CustomerComm.Tests\CustomerComm.Tests.csproj"
```