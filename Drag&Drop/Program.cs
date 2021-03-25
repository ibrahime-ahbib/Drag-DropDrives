using System;
using System.IO;

/**
 * @file Program.cs
 * @author Ibrahime Ahbib (Braxoia)
 * @version 1 25/03/2021
 * @brief Copy a file or a directory
 * at the root of hard drives
 */

namespace DragNDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = args[0].Split(@"\"); //@ = échape les caractères de chemin de fichier
            string nameFile = path[^1]; //une case à partir de la fin
           
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.Name == @"C:\")
                {
                    continue;
                }

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
    }
}