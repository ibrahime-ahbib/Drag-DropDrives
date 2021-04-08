using System;
using System.IO;

namespace DraNDrop
{
    public class DragNDrop
    {
        /**
         * Copy file(s) or directory(ies) in multiple hard drives
         * @param input_path the path of directory or file to copy
         */
        public static void DNDrop(string input_path)
        {
            string[] path = input_path.Split(@"\"); //@ = échape les caractères de chemin de fichier 
            string nameFile = path[^1]; //une case à partir de la fin 
           
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.Name == @"C:\")
                {
                    continue;
                }
                
                string destFileName = $"{drive.Name}{nameFile}";
                
                FileAttributes attr = File.GetAttributes(input_path);
                if ((attr & FileAttributes.Directory) != 0)
                {
                    DirectoryCopy(input_path, destFileName, true);
                }
                else
                {
                    try
                    {
                        File.Copy(input_path, destFileName, true);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.Error.WriteLine("Ce fichier n'existe pas ! (Remerciez Ibrahime ;-)");
                    }
                }
            }
        }
        
        /**
         * Copy a directory and his content at the root of hard drive
         * @param sourceDirname the source of directory
         * @param copySubDirs copy also subdirectories 
         */
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            Console.WriteLine(sourceDirName);
            
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