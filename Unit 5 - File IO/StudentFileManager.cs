using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5___File_IO
{
    public class StudentFileManager
    {

        public void WriteNameToFile(string name)
        {
            var fileDirectory = TryGetStudentFile();

            if (File.Exists(fileDirectory) )
            {
                File.AppendAllText(fileDirectory, name);
            }
            else
            {
                File.WriteAllText(fileDirectory, name);
            }
        }

        public void WriteNameToFile(IEnumerable<string> names)
        {
            var fileDirectory = TryGetStudentFile();

            if (File.Exists(fileDirectory))
            {
                File.AppendAllLines(fileDirectory, names);
            }
            else
            {
                File.WriteAllLines(fileDirectory, names);
            }
        }

        public string[] GetAllNames()
        {
            var fileDirectory = TryGetStudentFile();

            var names = File.ReadAllLines(fileDirectory);

            return names;
        }

        public List<string> GetAllNamesFromFile()
        {
            // a stream like a river flowing... as stream of "something" flowing
            var fileDirectory = TryGetStudentFile();

            // a stream is an Open connection to Data that Flows over time
            // until that Data is exhausted
            // in this context, we create a StreamReader, and this StreamReader
            // is responsible for READING the file lines FOR YOU until
            // there are no more lines to read.
            using var fileReaderStream = new StreamReader(fileDirectory);

            // dispose in this context means that the StreamReader 
            // will STOP READING this file
            // as a developer, you will NOT have to call dispose manually,
            // you just simply have to put the using keyword 
            // in front of the variable that  references the IDisposable type
            // fileReaderStream.Dispose();  all dispose methods get called at 
            // the end of a method as long as you have the using keyword in 
            // front of the variable.

            var names = new List<string>();
            string currentLine;
            do
            {
                currentLine = fileReaderStream.ReadLine();
                if (currentLine == null)
                {
                    break;
                }

                names.Add(currentLine);
            }
            while (true);

            return names;
        }

        private string TryGetStudentFile()
        {
            var appDirectory = TryGetAppDirectory();

            //C: \Users\jjack\AppData\Local\StudentManager\student.txt
            var fileDirectory = Path.Combine(appDirectory, "student.txt");

            return fileDirectory;
        }

        private string TryGetAppDirectory()
        {
            // getting the special directory enum
            var appDataPath = Environment.SpecialFolder.LocalApplicationData;
            // will get the ACTUAL PATH on this specific computer
            // C:\Users\jjack\AppData\Local
            string localAppDataPath = Environment.GetFolderPath(appDataPath);


            // the Path class contains helper methods when working
            // with paths to files and directories.
            // C:\Users\jjack\AppData\Local\StudentManager
            string studentAppPath = Path.Combine(localAppDataPath, "StudentManager");

            // return true if directory DOES exist
            if (!Directory.Exists(studentAppPath))
            {
                // the Directory class contains helper methods to work
                // with... directories
                Directory.CreateDirectory(studentAppPath);
            }

            return studentAppPath;
        }


        // IF you wanted to UPDATE an existing NAME in your names files,
        // you would have to GetAllNames first, do your logic to update
        // whatever name,
        // then instead of Appending to that file, make sure you Overrite the 
        // entire file using File.WriteAllLine().
    }
}
