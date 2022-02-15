using System;
using System.IO;

namespace Lesson5_4_Recursion
{
    class Task4_Rec
    {
        static void Main(string[] args)
        {
			string workDir = @"C:\Homework\Homework"; 
			GetFolderContent(workDir);

			static void GetFolderContent(string workDir) 
			{
				string filename = @"C:\Homework\Homework\Lesson5-4-Recursion\Tree.txt"; 
				if (Directory.Exists(workDir)) 
				{
					string[] files = Directory.GetFileSystemEntries(workDir, "*", SearchOption.TopDirectoryOnly); 
					File.AppendAllLines(filename, files);
				
					for (int i = 0; i < files.Length; i++)
                    {
                        GetFolderContent(files[i]);						
                    }
                }
			}
		}
    }
}
