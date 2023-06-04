using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class StringExtensionMethodsTests
    {
        [TestMethod]
        public void GetInnerText_ReturnsCorrectInnerText()
        {
            var input = "preambleHello, World!postscript";
            var result = input.GetInnerText("preamble", "postscript");

            Assert.AreEqual("Hello, World!", result);
        }

        [TestMethod]
        public void GetInnerText_ReturnsEmptyString_WhenPreambleOrPostscriptNotFound()
        {
            var input = "Hello, World!";
            var result = input.GetInnerText("preamble", "postscript");

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetInnerText_ThrowsArgumentNullException_WhenInputIsNull()
        {
            string? input = null;

            Assert.ThrowsException<ArgumentNullException>(() => input.GetInnerText("preamble", "postscript"));
        }

        [TestMethod]
        public void GetInnerText_ThrowsArgumentNullException_WhenPreambleIsNull()
        {
            string? preamble = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerText(preamble, "postscript"));
        }

        [TestMethod]
        public void GetInnerText_ThrowsArgumentNullException_WhenPostscriptIsNull()
        {
            string? postscript = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerText("preamble", postscript));
        }

        [TestMethod]
        public void GetInnerTextList_ReturnsCorrectList()
        {
            var input = "preambleHello, World!postscript preambleHello Again!postscript";
            var result = input.GetInnerTextList("preamble", "postscript");
            var expected = new List<string> { "Hello, World!", "Hello Again!" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetInnerTextList_ReturnsEmptyList_WhenPreambleOrPostscriptNotFound()
        {
            var input = "Hello, World! Hello Again!";
            var result = input.GetInnerTextList("preamble", "postscript");

            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void GetInnerTextList_ThrowsArgumentNullException_WhenInputIsNull()
        {
            string? input = null;

            Assert.ThrowsException<ArgumentNullException>(() => input.GetInnerTextList("preamble", "postscript"));
        }

        [TestMethod]
        public void GetInnerTextList_ThrowsArgumentNullException_WhenPreambleIsNull()
        {
            string? preamble = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerTextList(preamble, "postscript"));
        }

        [TestMethod]
        public void GetInnerTextList_ThrowsArgumentNullException_WhenPostscriptIsNull()
        {
            string? postscript = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerTextList("preamble", postscript));
        }

        [TestMethod]
        public void ToByteArrayUtf8_ReturnsCorrectByteArray()
        {
            var input = "Hello, World!";
            var result = input.ToByteArrayUtf8();
            var expected = Encoding.UTF8.GetBytes(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToByteArrayUtf8_ThrowsArgumentNullException_WhenInputIsNull()
        {
            string? input = null;

            Assert.ThrowsException<ArgumentNullException>(() => input.ToByteArrayUtf8());
        }

        [TestMethod]
        public void GetInnerTextList_IgnoreCase_ReturnsCorrectList()
        {
            var input = "PREAMBLEHello, World!POSTSCRIPT PREAMBLEHello Again!POSTSCRIPT";
            var result = input.GetInnerTextList("preamble", "postscript", true);
            var expected = new List<string> { "Hello, World!", "Hello Again!" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetInnerTextList_IgnoreCase_ReturnsEmptyList_WhenPreambleOrPostscriptNotFound()
        {
            var input = "Hello, World! Hello Again!";
            var result = input.GetInnerTextList("PREAMBLE", "POSTSCRIPT", true);

            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void GetInnerTextList_IgnoreCase_ThrowsArgumentNullException_WhenInputIsNull()
        {
            string? input = null;

            Assert.ThrowsException<ArgumentNullException>(() => input.GetInnerTextList("preamble", "postscript", true));
        }

        [TestMethod]
        public void GetInnerTextList_IgnoreCase_ThrowsArgumentNullException_WhenPreambleIsNull()
        {
            string? preamble = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerTextList(preamble, "postscript", true));
        }

        [TestMethod]
        public void GetInnerTextList_IgnoreCase_ThrowsArgumentNullException_WhenPostscriptIsNull()
        {
            string? postscript = null;

            Assert.ThrowsException<ArgumentNullException>(() => "Hello, World!".GetInnerTextList("preamble", postscript, true));
        }

        [TestMethod]
        public void GetInnerText_ReturnsEmptyString_WhenPostscriptNotFound()
        {
            var input = "preambleHello, World!";
            var result = input.GetInnerText("preamble", "postscript");

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GetInnerText_IgnoreCase_ReturnsEmptyString_WhenPostscriptNotFound()
        {
            var input = "PREAMBLEHello, World!";
            var result = input.GetInnerText("preamble", "postscript", true);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Test_GetInnerTextList_MultipleDistinctSubstrings()
        {
            string input = "preambleHellopostscriptpreambleWorldpostscript";
            List<string> expected = new() { "Hello", "World" };
            List<string> actual = input.GetInnerTextList("preamble", "postscript");
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetInnerTextList_MultipleIdenticalSubstrings()
        {
            string input = "preambleHellopostscriptpreambleHellopostscript";
            List<string> expected = new() { "Hello" };
            List<string> actual = input.GetInnerTextList("preamble", "postscript");
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetInnerTextList_IncompleteFinalSubstring()
        {
            string input = "preambleHellopostscriptpreambleWorld";
            List<string> expected = new() { "Hello" };
            List<string> actual = input.GetInnerTextList("preamble", "postscript");
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetInnerTextList_NoValidInnerText()
        {
            string input = "preamblepostscript";
            List<string> expected = new();
            List<string> actual = input.GetInnerTextList("preamble", "postscript");
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}