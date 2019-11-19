using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using SystemHelpers.FileOperations;

namespace SGDFileConverter
{
    class FileOperations
    {
        public string fileContents { get; set; }
        public string fileLocation { get; set; }
        StreamReader streamReader;
        FileStream fileStream;
        StreamWriter streamWriter;
        /// <summary>
        /// Set the location of the file to look for when the class is instantiated
        /// </summary>
        /// <param name="FileLocation"></param>
        public FileOperations(string FileLocation)
        {
            fileLocation = FileLocation;
        }

        public bool ReadFile()
        {
            using (fileStream = new FileStream(fileLocation, FileMode.Open))
            {
                streamReader = new StreamReader(fileStream);
                fileContents = streamReader.ReadToEnd();
            }
            return true;
        }

        public bool WriteToFile()
        {
            if (fileContents.Length > 0)
            {
                using (fileStream = new FileStream(fileLocation, FileMode.OpenOrCreate))
                {
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.AutoFlush = true;
                    streamWriter.Write(fileContents);
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        public bool WriteToFile(FileMode WriteFileMode)
        {
            if (fileContents.Length > 0)
            {
                using (fileStream = new FileStream(fileLocation, WriteFileMode))
                {
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.AutoFlush = true;
                    streamWriter.Write(fileContents);
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        public bool WriteToFile(FileMode WriteFileMode, string Data)
        {
            if (Data.Length > 0)
            {
                using (fileStream = new FileStream(fileLocation, WriteFileMode))
                {
                    streamWriter = new StreamWriter(fileStream);
                    streamWriter.AutoFlush = true;
                    streamWriter.Write(Data);
                }
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
