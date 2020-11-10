using System.Collections.Generic;
using System.IO;
using System;

namespace ppqq
{
    class FileListDetails
    {
        //The directory path
        public string path;
        //Whether contain subdirectories
        public Boolean containChild;
        //The file count
        public int count = 0;
        //File name collection
        public string nameCollection="";
        //Full file path collection
        public string fullNameCollection="";
        // The file name list, does not contain complete path
        public List<string> nameList = new List<string>();
        //The full file name list,contain complete path
        public List<string> fullNameList = new List<string>();
        //The file list
        public List<FileInfo> fileList = new List<FileInfo>();
        //Error message
        public string errorMsg = "";
        public FileListDetails(string directoryPath, Boolean contain)
        {
            path = directoryPath;
            containChild = contain;
            if (!Directory.Exists(path))
            {
                errorMsg = "The path is no a valid directory!";
                return;
            }
            readFileList(path,contain);
        }
        public void reload()
        {
            clear();
            readFileList(path, containChild);
        }
        public void reload(string directoryPath, Boolean contain)
        {
            clear();
            path = directoryPath;
            containChild = contain;
            if (!Directory.Exists(path)) throw(new Exception());
            readFileList(path, contain);
        }
        private void readFileList(string directoryPath, Boolean contain)
        {
            getFileListInDirectory(path, contain);
            count = fileList.Count;
            getName();
        }
        public void clear()
        {
            count = 0;
            nameList.Clear();
            fullNameList.Clear();
            fileList.Clear();
        }
        private void getFileListInDirectory(string directory,Boolean containChild)
        {
            DirectoryInfo dire = new DirectoryInfo(directory);
            DirectoryInfo[] directoryArray = dire.GetDirectories();
            FileInfo[] fileInfoArray = dire.GetFiles();
            if (fileInfoArray.Length > 0) fileList.AddRange(fileInfoArray);
            if (containChild)
            {
                foreach (DirectoryInfo _directoryInfo in directoryArray)
                {//遍历子目录
                    getFileListInDirectory(_directoryInfo.FullName, containChild);
                }
            }
        }
        private void getName()
        {
            FileDetails fd;
            foreach (FileInfo f in fileList){
                fd = new FileDetails(f.FullName);
                nameList.Add(fd.name);
                fullNameList.Add(f.FullName);
                nameCollection += fd.name + fd.type+"\r\n";
                fullNameCollection += fd.fullName + "\r\n";
            }
        }
    }
}
