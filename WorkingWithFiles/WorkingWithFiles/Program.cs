using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/Aurimas/Documents/dotnet/HYeaNB2.jpg";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

            File.Copy(@"/Users/Aurimas/Documents/dotnet/WorkingWithFiles/Nuotrauka (B&W).jpg", @"/Users/Aurimas/Documents/dotnet/Nuotrauka (B&W).jpg", true); // Copies a photo
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            } // static method

            //Directory.CreateDirectory(@"/Users/Aurimas/Documents/dotnet/TemporaryFolder");

            //var files = Directory.GetFiles(@"/Users/Aurimas/Documents/dotnet", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"/Users/Aurimas/Documents/dotnet", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"/Users/Aurimas/Documents/dotnet/TemporaryFolder");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            } // instance method

        }
    }
}
