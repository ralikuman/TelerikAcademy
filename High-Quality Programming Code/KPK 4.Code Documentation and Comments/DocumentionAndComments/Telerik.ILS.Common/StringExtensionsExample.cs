// <copyright file="StringExtensionsExample.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Telerik.ILS.Common
{
    using System;
    using System.Linq;

    /// <summary>
    ///  Example how can use class StringExtensions 
    /// </summary>
    public class StringExtensionsExample
    {
        /// <summary>
        /// Example of class StringExtensions
        /// </summary>
        public static void Main()
        {
            // Test extension method ToMd5Hash
            string value = "StringExtensions";
            Console.WriteLine(StringExtensions.ToMd5Hash(value));

            // Test extension method ToBoolean
            string testTrue = "true";
            Console.WriteLine(StringExtensions.ToBoolean(testTrue)); // True

            string testFalse = "false";
            Console.WriteLine(StringExtensions.ToBoolean(testFalse)); // False

            string testYes = "yes";
            Console.WriteLine(StringExtensions.ToBoolean(testYes)); // True

            // Test extension method ToShort
            string testCorrectShortValue = "45";
            Console.WriteLine(StringExtensions.ToShort(testCorrectShortValue)); // 45

            string testWrongShortValue = "45 wrong";
            Console.WriteLine(StringExtensions.ToShort(testWrongShortValue)); // 0

            // Test extension method ToLong
            string testCorrectLongValue = "4589094568934839393";
            Console.WriteLine(StringExtensions.ToLong(testCorrectLongValue)); // 4589094568934839393

            string testWrongLongValue = "45 wrong";
            Console.WriteLine(StringExtensions.ToLong(testWrongLongValue)); // 0

            // Test extension method ToInteger
            string testCorrectIntegerValue = "56934567";
            Console.WriteLine(StringExtensions.ToInteger(testCorrectIntegerValue)); // 56934567

            string testWrongIntegerValue = "ineger 345";
            Console.WriteLine(StringExtensions.ToInteger(testWrongIntegerValue)); // 0

            // Test extension method ToDateTime
            string correctDate = "2013.04.27 20:00";
            Console.WriteLine(StringExtensions.ToDateTime(correctDate));

            string wrongDate = "wrongDate";
            Console.WriteLine(StringExtensions.ToDateTime(wrongDate));

            // Test extension method CapitalizeFirstLetter
            string capitalizeText = "telerik";
            Console.WriteLine(StringExtensions.CapitalizeFirstLetter(capitalizeText)); // Telerik

            // Test extension method GetStringBetween
            string descriptionOfDateTime = "Initializes a new instance of the DateTime structure to a specified number of ticks.";
            Console.WriteLine(StringExtensions.GetStringBetween(descriptionOfDateTime, "new", "DateTime", 0)); // instance of the

            // Test extension method ConvertCyrillicToLatinLetters
            string cyrilicText = "Софтуерна академия";
            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(cyrilicText)); // Softuerna akademiya

            // Test extension method ConvertLatinToCyrillicKeyboard
            string latinText = "Telerik";
            Console.WriteLine(StringExtensions.ConvertLatinToCyrillicKeyboard(latinText)); // Телерик

            // Test extension method ToValidUsername
            string username = "академия";
            Console.WriteLine(StringExtensions.ToValidUsername(username)); // akademiya

            // Test extension method ToValidLatinFileName
            string filename = @"file:///C:/Users/Desktop//дом-manipulation-демо/";
            Console.WriteLine(StringExtensions.ToValidUsername(filename)); // fileCUsersDesktopdommanipulationdemo

            // Test extension method GetFirstCharacters
            string descriptionOfMD5Algorithm = "The MD5 Message-Digest Algorithm is a widely used cryptographic hash function that produces a 128-bit (16-byte) hash value.";
            Console.WriteLine(StringExtensions.GetFirstCharacters(descriptionOfMD5Algorithm, 32)); // The MD5 Message-Digest Algorithm

            // Test extension method GetFileExtension
            string fileName = "telerik.docx";
            Console.WriteLine(StringExtensions.GetFileExtension(fileName)); // docx

            string fileNameNoExtension = "telerik";
            Console.WriteLine(StringExtensions.GetFileExtension(fileNameNoExtension));

            // Test extension method ToContentType
            Console.WriteLine(StringExtensions.ToContentType(fileName)); // application/octet-stream
        }
    }
}
