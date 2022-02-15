using System;
using System.IO;

namespace FileManager
{
    class FileManager
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.workDir))
            {
                DrawArea();
                Console.WriteLine("Which directory would you like to work in?");
                Properties.Settings.Default.workDir = Console.ReadLine();

                GetCatalog(Properties.Settings.Default.workDir);

                Properties.Settings.Default.Save();
            }
            void PrintTextInBox(string[] text)
            {
                DrawArea();
                int textBoxWidth = 117; // Width of the console window by default is 120 symbols, 3 are taken by margins
                int textBoxHeight = Properties.Settings.Default.pagination; // Width of the console window by default is 30 symbols, 3 are taken by the header, 1 by footer and 1 for input
                string blankLine = "║";
                string footer = "╚";
                for (int i = 0; i < textBoxWidth; i++) // 2 symbols are taken up by ║ or ╚
                {
                    blankLine += " ";
                    footer += "═";
                }
                blankLine += "║";
                footer += "╝";

                if (text.Length <= textBoxHeight)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i].Length <= textBoxWidth)
                        {
                            string temp = "";
                            for (int j = 0; j < textBoxWidth - text[i].Length; j++)
                            {
                                temp += " ";
                            }
                            Console.WriteLine("║" + text[i] + temp + "║");
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    for (int i = 0; i < textBoxHeight - text.Length; i++)
                    {
                        Console.WriteLine(blankLine);
                    }
                    Console.WriteLine(footer);
                    Console.WriteLine("What would you like to do? Say \"help\" to list commands. ");
                }
                else
                {
                    for (int i = 0; i < textBoxHeight; i++)
                    {
                        if (text[i].Length <= textBoxWidth)
                        {
                            string temp = "";
                            for (int j = 0; j < textBoxWidth - text[i].Length; j++)
                            {
                                temp += " ";
                            }
                            Console.WriteLine("║" + text[i] + temp + "║");
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    for (int i = 0; i < textBoxHeight - text.Length; i++)
                    {
                        Console.WriteLine(blankLine);
                    }
                    Console.WriteLine(footer);
                    string waitForInput = Console.ReadLine();
                    string[] newText = new string[text.Length - textBoxHeight];
                    for (int i = textBoxHeight; i < text.Length; i++)
                    {
                        newText[i - textBoxHeight] = text[i];
                    }
                    PrintTextInBox(newText);

                }
            }
            PrintTextInBox(new string[0]); // Output a blank form with command prompt
            while (true)
            {
                string action = Console.ReadLine();
                string[] actionArray = action.Split(' ');
                string[] commands = new string[8] { "GetCatalog", "CopyFile", "CopyDirectory", "FileInfo", "DirInfo", "DeleteFile", "DeleteDir", "SetPaginationSetting" };

                switch (actionArray[0])
                {
                    case "GetCatalog":
                        try
                        {
                            GetCatalog(actionArray[1]);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.StackTrace}");
                        }
                        break;

                    case "CopyFile":
                        try
                        {
                            CopyFile(actionArray[1], actionArray[2]);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.StackTrace}");
                        }
                        break;

                    case "CopyDirectory":
                        try
                        {
                            CopyDirectory(actionArray[1], actionArray[2]);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.StackTrace}");
                        }
                        break;

                    case "FileInfo":
                        try
                        {
                            FileInfo(actionArray[1]);
                        }
                        catch
                        {

                        }
                        break;

                    case "DirInfo":
                        try
                        {
                            PrintTextInBox(new string[] { Convert.ToString(DirInfoCalc(actionArray[1])) + " bytes" });
                            //Console.WriteLine($"{DirInfoCalc(actionArray[1])}");
                        }
                        catch
                        {

                        }
                        break;

                    case "DeleteFile":
                        try
                        {
                            DeleteFile(actionArray[1]);
                            Console.WriteLine($"{actionArray[1]} was deleted successfully.");
                            Console.WriteLine("");
                        }
                        catch
                        {

                        }
                        break;

                    case "DeleteDir":
                        try
                        {
                            DeleteDir(actionArray[1]);
                            Console.WriteLine($"{actionArray[1]} was deleted successfully.");
                            Console.WriteLine("");
                        }
                        catch
                        {

                        }
                        break;

                    case "help":
                        PrintTextInBox(commands);

                        /*for(int i = 0; i < commands.Length; i++)
                        {
                            Console.WriteLine(commands[i]);
                        }*/
                        break;
                    case "SetPaginationSetting":
                        try
                        {
                            int newPagination = Convert.ToInt32(actionArray[1]);
                            if (1 <= newPagination && newPagination <= 24)
                            {
                                Properties.Settings.Default.pagination = newPagination;
                                Properties.Settings.Default.Save();
                                PrintTextInBox(new string[] { $"Pagination set to {newPagination}" });
                                break;
                            }
                            else
                            {
                                PrintTextInBox(new string[] { "Invalid argument for PaginationSize" });
                                break;
                            }
                        }
                        catch
                        {
                            PrintTextInBox(new string[] { "Invalid argument for PaginationSize" });
                            break;
                        }

                    default:
                        PrintTextInBox(new string[] { "There is no such command. Please try again." });
                        //Console.WriteLine("There is no such command. Please try again.");
                        //Console.WriteLine("");
                        break;
                }

            }

            void DrawArea()
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                  "║                                                           TREE                                                      ║\n" +
                                  "╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }

            void GetCatalog(string directory)
            {
                if (Directory.Exists(directory))
                {
                    Properties.Settings.Default.workDir = directory;

                    // Console.WriteLine($"{Properties.Settings.Default.workDir}");
                    string[] entries = Directory.GetFileSystemEntries(directory, "*", SearchOption.TopDirectoryOnly);

                    /*for (int i = 0; i < entries.Length; i++)
                    {
                        Console.WriteLine(entries[i]);
                    }*/
                    string[] output = new string[entries.Length + 1];
                    output[0] = Properties.Settings.Default.workDir;
                    entries.CopyTo(output, 1); // this hack basically creates a String[] out of the dir name + Directory.GetFileSystemEntries output

                    PrintTextInBox(output);
                }
                else
                {
                    PrintTextInBox(new string[] { "There is no such directory here. Please try again." });
                }
            }

            void CopyFile(string file, string targetDirectory)
            {
                if (File.Exists(file))
                {
                    if (Directory.Exists(targetDirectory))
                    {
                        File.Copy(file, Path.Combine(targetDirectory, file)); // Копируем созданную заметку в "D:\ExampleDir\Copy of Note 1.txt"
                    }
                    else
                    {
                        PrintTextInBox(new string[] { "There is no such directory. Please, try again" });
                        //Console.WriteLine("There is no such directory. Please, try again");
                    }
                }
                else
                {
                    PrintTextInBox(new string[] { "File does not exist. Please try again" });
                    //Console.WriteLine("File does not exist. Please try again");
                }
                return;
            }

            void CopyDirectory(string sourceDirectory, string targetDirectory)
            {
                string[] entities = Directory.GetFileSystemEntries(sourceDirectory, "*", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < entities.Length; i++)
                {
                    string[] folderNameArray = entities[i].Split('\\');
                    string folderName = folderNameArray[folderNameArray.Length - 1];
                    if (Directory.Exists(entities[i]))
                    {
                        Directory.CreateDirectory(Path.Combine(targetDirectory, folderName));
                        CopyDirectory(entities[i], Path.Combine(targetDirectory, folderName));
                    }
                    else if (File.Exists(entities[i]))
                    {
                        File.Copy(entities[i], Path.Combine(targetDirectory, folderName));
                    }

                }
            }

            void FileInfo(string file)
            {
                if (File.Exists(file))
                {
                    FileAttributes fileAttributes = File.GetAttributes(file);
                    long fileSize = new System.IO.FileInfo(file).Length;
                    string[] output = new string[] { Convert.ToString(fileAttributes), Convert.ToString(fileSize) + " bytes" };
                    //Console.WriteLine($"{fileAttributes}");


                    //Console.WriteLine($"{fileSize}");
                    PrintTextInBox(output);
                }
                else
                {
                    PrintTextInBox(new string[] { "There is no such file here. Please, try again." });
                    //Console.WriteLine("There is no such file here. Please, try again.");
                    //Console.WriteLine("");
                }
            }

            long DirInfoCalc(string dir)
            {
                if (Directory.Exists(dir))
                {
                    string[] entities = Directory.GetFileSystemEntries(dir, "*", SearchOption.TopDirectoryOnly);
                    long dirSize = 0;
                    long fileSize = 0;

                    for (int i = 0; i < entities.Length; i++)
                    {
                        if (File.Exists(entities[i]))
                        {
                            fileSize = new System.IO.FileInfo(entities[i]).Length;
                            dirSize += fileSize;
                        }
                        else if (Directory.Exists(entities[i]))
                        {
                            dirSize += DirInfoCalc(entities[i]);
                        }
                    }
                    return dirSize;
                }
                return 0;
            }

            void DeleteFile(string file)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                else
                {
                    PrintTextInBox(new string[] { "There is no such file here. Please, try again." });
                    //Console.WriteLine("There is no such file here. Please, try again.");
                    //Console.WriteLine("");
                }
            }

            void DeleteDir(string dir)
            {
                if (Directory.Exists(dir))
                {
                    Directory.Delete(dir);
                }
                else
                {
                    PrintTextInBox(new string[] { "There is no such directory here. Please, try again." });
                    //Console.WriteLine("There is no such directory here. Please, try again.");
                    //Console.WriteLine("");
                }
            }
        }
    }
}