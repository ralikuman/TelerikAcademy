// <copyright file="StringExtensions.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Implementation of methods and functionality of class StringException
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Return string which representation is like 128-bit (16-byte) hash value of given input value.  
        /// </summary>
        /// <param name="input">string value which convert in hash value</param>
        /// <returns>string in hexidecimal (16-byte) hash value</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToMd5Hash"/> method.</remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string value = "StringExtensions";
        ///     Console.WriteLine(StringExtensions.ToMd5Hash(value)); // aeb321e7ed6fe8d70d430daccd79b183
        /// }
        /// </code>
        /// </example>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Return boolean value is the given value contains in defined array of words
        /// </summary>
        /// <param name="input">string value to seek</param>
        /// <returns>true if the value parameter occurs in determinate true words;  otherwise, false </returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToBoolean"/> method.
        /// True values are: true, ok, yes, 1, да. 
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string testTrue = "true";
        ///     Console.WriteLine(StringExtensions.ToBoolean(testTrue)); // True
        ///
        ///     string testFalse = "false";
        ///     Console.WriteLine(StringExtensions.ToBoolean(testFalse)); // False
        ///
        ///     string testYes = "yes";
        ///     Console.WriteLine(StringExtensions.ToBoolean(testYes)); //True
        /// }
        /// </code>
        /// </example>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Return short value if can parse the input value
        /// </summary>
        /// <param name="input">string value to parse</param>
        /// <returns>return short value if can parse the string value;  otherwise return 0 </returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToShort"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string testCorrectShortValue = "45";
        ///     Console.WriteLine(StringExtensions.ToShort(testCorrectShortValue)); // 45
        ///
        ///     string testWrongShortValue = "45 wrong";
        ///     Console.WriteLine(StringExtensions.ToShort(testWrongShortValue)); // 0
        /// }
        /// </code>
        /// </example>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Return integer value if can parse the input value
        /// </summary>
        /// <param name="input">string value to parse</param>
        /// <returns>return integer value if can parse the string value;  otherwise return 0 </returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToInteger"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///    string testCorrectIntegerValue = "567567";
        ///    Console.WriteLine(StringExtensions.ToInteger(testCorrectIntegerValue)); // 567567
        ///
        ///    string testWrongIntegerValue = "ineger 345";
        ///    Console.WriteLine(StringExtensions.ToInteger(testWrongIntegerValue)); // 0
        /// }
        /// </code>
        /// </example>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Return long value if can parse the input value
        /// </summary>
        /// <param name="input">string value to parse</param>
        /// <returns>return long value if can parse the string value;  otherwise return 0 </returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToLong"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string testCorrectLongValue = "4589094568934839393";
        ///     Console.WriteLine(StringExtensions.ToLong(testCorrectLongValue)); // 4589094568934839393
        ///
        ///     string testWrongLongValue = "45 wrong";
        ///     Console.WriteLine(StringExtensions.ToLong(testWrongLongValue)); // 0
        /// }
        /// </code>
        /// </example>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Return date and time expressed in the number of 100-nanosecond intervals in the Gregorian calendar 
        /// </summary>
        /// <param name="input">string value to parse</param>
        /// <returns>return date and time expressed in the number of 100-nanosecond intervals;
        ///          otherwise return 1.1.0001 г. 00:00:00 ч. 
        /// </returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToDateTime"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string correctDate = "2013.04.27 20:00";
        ///     Console.WriteLine(StringExtensions.ToDateTime(correctDate));  // 27.4.2013 г. 20:00:00 ч.
        /// 
        ///     string wrongDate = "wrongDate";
        ///     Console.WriteLine(StringExtensions.ToDateTime(wrongDate)); // 1.1.0001 г. 00:00:00 ч.
        /// }
        /// </code>
        /// </example>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Return string representation with capitalize frist letter of given text
        /// </summary>
        /// <param name="input">string value to capitalize</param>
        /// <returns>return string with capitalize first letter;</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="CapitalizeFirstLetter"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string capitalizeText = "telerik";
        ///     Console.WriteLine(StringExtensions.CapitalizeFirstLetter(capitalizeText)); // Telerik
        /// }
        /// </code>
        /// </example>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Return string between two substrings 
        /// </summary>
        /// <param name="input">the hole string value</param>
        /// <param name="startString">start substring</param>
        /// <param name="endString">end substring </param>
        /// <param name="startFrom">set start index to start search substring</param>
        /// <returns>substring between start and end substring</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="CapitalizeFirstLetter"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string descriptionOfDateTime = "Initializes a new instance of the DateTime structure to a specified number of ticks.";
        ///     Console.WriteLine(StringExtensions.GetStringBetween(descriptionOfDateTime, "new", "DateTime", 0)); //  instance of the
        /// }
        /// </code>
        /// </example>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Return string in latin letters, if there is letters in cyrillic they are replaced with latin letters
        /// </summary>
        /// <param name="input">the string to seek</param>
        /// <returns>string in latin letters</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ConvertCyrillicToLatinLetters"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string cyrilicText = "Софтуерна академия";
        ///     Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(cyrilicText)); // Softuerna akademiya
        /// }
        /// </code>
        /// </example>       
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Return string in cyrillic letters, if there is letters in latin they are replaced with cyrillic letters
        /// </summary>
        /// <param name="input">the string to seek</param>
        /// <returns>string in cyrillic letters</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ConvertLatinToCyrillicKeyboard"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string latinText = "Telerik";
        ///     Console.WriteLine(StringExtensions.ConvertLatinToCyrillicKeyboard(latinText)); // Телерик
        /// }
        /// </code>
        /// </example>   
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Return string in latin representation if there are cyrillic letters
        /// </summary>
        /// <param name="input">the string to seek</param>
        /// <returns>string value only in latin letters or numbers</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToValidUsername"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string username = "академия";
        ///     Console.WriteLine(StringExtensions.ToValidUsername(username)); // akademiya
        /// }
        /// </code>
        /// </example>  
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Return file name in latin representation if there are cyrillic letters
        /// </summary>
        /// <param name="input">file name to seek</param>
        /// <returns>file name only in latin letters or numbers</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="ToValidLatinFileName"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string filename = @"file:///C:/Users/Desktop//дом-manipulation-демо/";
        ///     Console.WriteLine(StringExtensions.ToValidUsername(filename)); // fileCUsersDesktopdommanipulationdemo
        /// }
        /// </code>
        /// </example>  
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Return substring from first characters by given count
        /// </summary>
        /// <param name="input">the given string to seek</param>
        /// <param name="charsCount">count of characters to be extract like substring</param>
        /// <returns>substring with length equal to charsCount</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="GetFirstCharacters"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string descriptionOfMD5Algorithm = "The MD5 Message-Digest Algorithm is a widely used cryptographic hash function that produces a 128-bit (16-byte) hash value.";
        ///     Console.WriteLine(StringExtensions.GetFirstCharacters(descriptionOfMD5Algorithm, 32)); // The MD5 Message-Digest Algorithm
        /// }
        /// </code>
        /// </example>       
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Return extension of file is there is
        /// </summary>
        /// <param name="fileName">string of given file name</param>
        /// <returns>extracted extension name of file or empty string</returns>
        /// <example>
        /// <remarks>This sample shows how to call the <see cref="GetFileExtension"/> method.
        /// </remarks>
        /// <code>
        /// public static void Main()
        /// {
        ///     string fileName = "telerik.docx";
        ///     Console.WriteLine(StringExtensions.GetFileExtension(fileName)); //docx
        ///
        ///     string fileNameNoExtension = "telerik";
        ///     Console.WriteLine(StringExtensions.GetFileExtension(fileNameNoExtension));
        /// }
        /// </code>
        /// </example> 
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Return content type of parameter from given file name as parameter
        /// </summary>
        /// <param name="fileExtension">string of file name</param>
        /// <returns>return content type as string</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert given string as parameter in sequence of bytes
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>a byte array</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
