using System;
using System.IO;

namespace DragNDrop
{
    public class Program
    {
        static void DraNDrop(string[] args)
        {
            string[] path = args[0].Split(@"\"); //@ = échape les caractères de chemin de fichier
            string nameFile = path[^1]; //une case à partir de la fin
           
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.Name == @"C:\")
                {
                    continue;
                }
                
                FileAttributes attr = File.GetAttributes(args[0]);
                
                    try
                    {
                        File.Copy(args[0], $"{drive.Name}{nameFile}", true);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.Error.WriteLine("Ce fichier n'existe pas ! (Remerciez Ibrahime ;-)");
                    }
            }
        }
        
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
        
            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);        

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
    }
}