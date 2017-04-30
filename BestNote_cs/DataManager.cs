using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace BestNote_cs
{
    public abstract class DataManager
    {
        public abstract ArrayList getFolderList();

        public abstract ArrayList getFileList(string folderName);

        public abstract FileStructure getFileContent(string fileName, string folderName);

        public abstract bool newFolder(string folderName);

        public abstract bool newFile(string fileName, string folderName, string fileContent);

        public abstract bool updateContent(string fileName, string folderName, string fileContent);

        public abstract bool renameFolder(string folderName, string newName);

        public abstract bool deleteFolder(string folderName);

        public abstract bool renameFile(string fileName, string newName, string folderName);

        public abstract bool deleteFile(string fileName, string folderName);

        public abstract void close();

        public struct FileStructure
        {
            public string content;
            public DateTime createTime;
            public DateTime modifyTime;
        }
    }
}