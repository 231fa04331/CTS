# NUnit Assignment

This folder contains the NUnit-only example from the module.

## What is here

- [CalcLibrary/CalcLibrary.csproj](CalcLibrary/CalcLibrary.csproj)
- [CalcLibrary/SimpleCalculator.cs](CalcLibrary/SimpleCalculator.cs)
- [CalcLibraryTests/CalcLibraryTests.csproj](CalcLibraryTests/CalcLibraryTests.csproj)
- [CalculatorTests.cs](../CalculatorTests.cs)

## What it does

The test verifies the `Addition` method in `SimpleCalculator` using NUnit test cases.

## Expected result

The run should pass all 3 test cases:

```text
Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0
```

## Run command

```powershell
& "C:\Program Files\dotnet\dotnet.exe" test "c:\Users\Lenovo\Desktop\CTS_repo\DeepSkilling\Module-4-NUnit-and-Moq\NUnit-Assignment\CalcLibraryTests\CalcLibraryTests.csproj"
```