using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PasswordController : ControllerBase
{
    [HttpGet("generate")]
    public IActionResult GeneratePassword(int length = 15, bool includeUppercase = true, bool includeLowercase = true, bool includeNumbers = false, bool includeSymbols = false)
    {
        var password = PasswordGenerator.Generate(length, includeUppercase, includeLowercase, includeNumbers, includeSymbols);
        return Ok(password);
    }
}

public static class PasswordGenerator
{
    private static readonly Random _random = new();

    public static string Generate(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSymbols)
    {
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string symbols = "!@#$%^&*()-_+=<>?";

        string charSet = string.Empty;
        if (includeUppercase) charSet += uppercase;
        if (includeLowercase) charSet += lowercase;
        if (includeNumbers) charSet += numbers;
        if (includeSymbols) charSet += symbols;

        return new string(Enumerable.Repeat(charSet, length)
                                     .Select(s => s[_random.Next(s.Length)])
                                     .ToArray());
    }
}
