using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*4.	Create a class Path to hold a sequence of points in the 3D space.
 * Create a static class PathStorage with static methods to save and load paths from a text file.
 * Use a file format of your choice.*/

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePathsInFile(Path path, string fileName)
        {
            string fileSaveName = fileName;  //= @"../../../paths.txt";
            StreamWriter fileOfPathPoints = new StreamWriter(fileSaveName);
            try
            {
                using (fileOfPathPoints)
                {
                    foreach (var point in path.PathOfPoints)
                    {
                        fileOfPathPoints.WriteLine(point);
                    }
                }
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found! {0}, {1}", dirEx.Message, dirEx.StackTrace);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message, ioEx.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public static Path LoadPathsFromFile(string fileName)
        {
            //fileName = @"../../../paths.txt";
            StreamReader loadFile = new StreamReader(fileName);
            Path loadPath = new Path();
            try
            {
                using (loadFile)
                {
                    while (loadFile.Peek() >= 0)
                    {
                        String line = loadFile.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("NOT FOUND {0}, {1}",dirEx.Message, dirEx.StackTrace);
            }
            catch (FileNotFoundException fileEx)
            {
                Console.WriteLine(fileEx.Message, fileEx.StackTrace);
            }
            catch (FileLoadException fileLoadEx)
            {
                Console.WriteLine(fileLoadEx.Message, fileLoadEx.StackTrace);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message, ioEx.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            return loadPath;
        }

    }
}
