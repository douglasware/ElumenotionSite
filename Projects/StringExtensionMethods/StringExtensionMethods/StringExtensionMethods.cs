using System.Collections.Generic;
using System;
using System.Text;

/// <summary>
/// This class provides extension methods for strings.
/// </summary>
public static class StringExtensionMethods
{
    /// <summary>
    /// Retrieves a substring from this instance. The substring starts at a specified character position of a preamble and ends at a specified character position of a postscript.
    /// </summary>
    /// <param name="input">The input string</param>
    /// <param name="preamble">The start substring</param>
    /// <param name="postscript">The end substring</param>
    /// <returns>The substring between the preamble and postscript, or empty string if they are not found.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input, preamble or postscript is null or empty</exception>
    /// <example>
    /// <code>
    /// string input = "preambleHello, World!postscript";
    /// string result = input.GetInnerText("preamble", "postscript"); // Returns "Hello, World!"
    /// </code>
    /// </example>
    public static string GetInnerText(this string input, string preamble, string postscript)
    {
        return input.GetInnerText(preamble, postscript, false);
    }

    /// <summary>
    /// Retrieves a substring from this instance with case sensitive or insensitive option. The substring starts at a specified character position of a preamble and ends at a specified character position of a postscript.
    /// </summary>
    /// <param name="input">The input string</param>
    /// <param name="preamble">The start substring</param>
    /// <param name="postscript">The end substring</param>
    /// <param name="ignoreCase">Boolean flag to indicate if the search should be case insensitive</param>
    /// <returns>The substring between the preamble and postscript, or empty string if they are not found.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input, preamble or postscript is null or empty</exception>
    /// <example>
    /// <code>
    /// string input = "PREAMBLEHello, World!POSTSCRIPT";
    /// string result = input.GetInnerText("preamble", "postscript", true); // Returns "Hello, World!"
    /// </code>
    /// </example>
    public static string GetInnerText(this string input, string preamble, string postscript, bool ignoreCase)
    {
        if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));
        if (string.IsNullOrEmpty(preamble)) throw new ArgumentNullException(nameof(preamble));
        if (string.IsNullOrEmpty(postscript)) throw new ArgumentNullException(nameof(postscript));

        var comparisonType = ignoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.Ordinal;
        var start = input.IndexOf(preamble, comparisonType);

        if (start == -1) return string.Empty;
        start += preamble.Length;

        var end = input.IndexOf(postscript, start, comparisonType);
        if (end == -1) return string.Empty;

        return input.Substring(start, end - start);
    }

    /// <summary>
    /// Converts a string into a byte array using UTF-8 encoding.
    /// </summary>
    /// <param name="input">The input string</param>
    /// <returns>The byte array representation of the input string</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null or empty</exception>
    /// <example>
    /// <code>
    /// string input = "Hello, World!";
    /// byte[] result = input.ToByteArrayUtf8(); // Returns the byte array of the string
    /// </code>
    /// </example>
    public static byte[] ToByteArrayUtf8(this string input)
    {
        if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));
        return Encoding.UTF8.GetBytes(input);
    }

    /// <summary>
    /// Retrieves a list of substrings from this instance. The substrings start at a specified character position of a preamble and end at a specified character position of a postscript.
    /// </summary>
    /// <param name="input">The input string</param>
    /// <param name="preamble">The start substring</param>
    /// <param name="postscript">The end substring</param>
    /// <returns>A list of substrings between the preamble and postscript</returns>
    /// <exception cref="ArgumentNullException">Thrown when input, preamble or postscript is null or empty</exception>
    /// <example>
    /// <code>
    /// string input = "preambleHello, World!postscript preambleHello Again!postscript";
    /// List&lt;string&gt; result = input.GetInnerTextList("preamble", "postscript"); // Returns ["Hello, World!", "Hello Again!"]
    /// </code>
    /// </example>
    public static List<string> GetInnerTextList(this string input, string preamble, string postscript)
    {
        return input.GetInnerTextList(preamble, postscript, false);
    }

    /// <summary>
    /// Retrieves a list of substrings from this instance with case sensitive or insensitive option. The substrings start at a specified character position of a preamble and end at a specified character position of a postscript.
    /// </summary>
    /// <param name="input">The input string</param>
    /// <param name="preamble">The start substring</param>
    /// <param name="postscript">The end substring</param>
    /// <param name="ignoreCase">Boolean flag to indicate if the search should be case insensitive</param>
    /// <returns>A list of substrings between the preamble and postscript</returns>
    /// <exception cref="ArgumentNullException">Thrown when input, preamble or postscript is null or empty</exception>
    /// <example>
    /// <code>
    /// string input = "PREAMBLEHello, World!POSTSCRIPT PREAMBLEHello Again!POSTSCRIPT";
    /// List&lt;string&gt; result = input.GetInnerTextList("preamble", "postscript", true); // Returns ["Hello, World!", "Hello Again!"]
    /// </code>
    /// </example>
    public static List<string> GetInnerTextList(this string input, string preamble, string postscript, bool ignoreCase)
    {
        if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));
        if (string.IsNullOrEmpty(preamble)) throw new ArgumentNullException(nameof(preamble));
        if (string.IsNullOrEmpty(postscript)) throw new ArgumentNullException(nameof(postscript));

        var retVal = new List<string>();
        string lastVal;
        var current = input;

        do
        {
            lastVal = current.GetInnerText(preamble, postscript, ignoreCase);

            if (!string.IsNullOrEmpty(lastVal))
            {
                if (!retVal.Contains(lastVal)) retVal.Add(lastVal);

                var lastIndex = current.IndexOf(lastVal, StringComparison.Ordinal);
                current = lastIndex != -1 ? current.Substring(lastIndex + lastVal.Length - 1) : string.Empty;
            }
        } while (!string.IsNullOrEmpty(lastVal));

        return retVal;
    }
}

