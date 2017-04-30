using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestNote_cs
{
    public interface MainFunctions
    {
        void showFolderList();

        void showFileList(string folderName);

        void showFileContent(string folderName, string fileName);

        void newFolder();

        void renameFolder();

        void deleteFolder();

        void newFile();

        void renameFile();

        void deleteFile();

        void saveFile();
    }
}