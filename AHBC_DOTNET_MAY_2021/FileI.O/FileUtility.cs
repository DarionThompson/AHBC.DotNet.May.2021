using System;
using System.IO;

namespace FileI.O
{
    public class FileUtility
    {
        public void CreateFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
        }
    }
}
