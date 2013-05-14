namespace CohesionAndCoupling
{
    using System;

    public static class FileUtility
    {
        public static string GetFileExtension(string pathToFile)
        {
            if (pathToFile == null)
            {
                throw new ArgumentNullException("Given path to file is null.");
            }
            
            int indexOfLastDot = pathToFile.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = pathToFile.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string pathToFile)
        {
            if (pathToFile == null)
            {
                throw new ArgumentNullException("Given path to file is null.");
            }

            int indexOfLastDot = pathToFile.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return pathToFile;
            }

            string extension = pathToFile.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
