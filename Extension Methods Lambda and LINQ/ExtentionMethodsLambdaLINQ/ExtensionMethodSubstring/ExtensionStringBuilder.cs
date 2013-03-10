using System;
using System.Text;

public static class ExtensionStringBuilder
{
    /*1.	Implement an extension method Substring(int index, int length) 
     * for the class StringBuilder that returns new StringBuilder and has the same functionality
     * as Substring in the class String.*/

    public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int length)
    {
        StringBuilder result = new StringBuilder();
        if (startIndex < 0 || length < 0)
        {
            throw new ArgumentOutOfRangeException(String.Format("Start index or lenght can not be negative {0}, {1}", startIndex, length));
        }
        else if (startIndex >= strBuilder.Length)
        {
            throw new ArgumentOutOfRangeException(String.Format("Start index should be smaller than lenght of StringBuilder. Start index {0} and Lenght {1}", startIndex, strBuilder.Length));
        }
        else if ((startIndex + length) > strBuilder.Length)
        {
            throw new ArgumentOutOfRangeException(String.Format("Sum of startIndex and length {0} can not be bigger than lenght of StringBuilder {1} ", (startIndex + length), strBuilder.Length));
        }
        else
        {
            string temp = strBuilder.ToString().Substring(startIndex, length);
            result.Append(temp);
        }
        return result;
    }
}

