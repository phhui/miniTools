using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ppqq
{
    class FileHelper
    {
        /// <summary>The command is executed success</summary>
        public const int CMD_OK= 1;
        ///<summary>The file is no found</summary>
        public const int CMD_FAILE_NO_FOUND = 0;
        ///<summary>The file is using</summary>
        public const int CMD_FAILE_IN_USE = 2;
        ///<summary>The file already exists</summary>
        public const int CMD_FILE_ALREADY_EXISTS = 3;
        ///<summary>The path is no a valid directory</summary>
        public const int CMD_PATH_NO_DIRECTORY = 4;

        public const int CMD_TYPE_IMG = 10;

        public const int CMD_TYPE_TXT = 11;

        public const int CMD_TYPE_OTHER = 12;
        public static int deleteFile(string path)
        {
            if (!File.Exists(path)){return CMD_FAILE_NO_FOUND; }
            if (IsFileInUse(path)) { return CMD_FAILE_IN_USE; }
            File.Delete(path);
            return CMD_OK;
        }
        public static int moveFile(string path,string newPath)
        {
            if (!File.Exists(path)){return CMD_FAILE_NO_FOUND; }
            if (IsFileInUse(path)) { return CMD_FAILE_IN_USE; }
            if (File.Exists(newPath)) { return CMD_FILE_ALREADY_EXISTS; }
            File.Move(path, newPath);
            return CMD_OK;
        }
        public static FileListDetails getFileList(string path,Boolean containChild)
        {
            return new FileListDetails(path, containChild);
        }
        public static bool IsFileInUse(string fileName)
        {
            bool inUse = true;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read,FileShare.None);
                inUse = false;
            }catch{}
            finally{
                if (fs != null)
                    fs.Close();
            }
            return inUse;//true表示正在使用,false没有使用  
        }
        public static int checkType(string url)
        {
            string type = url.Substring(url.LastIndexOf(".")+1).ToLower(); ;
            if (type == "jpg" || type == "jpeg" || type == "png" || type == "bmp" || type == "gif")
            {
                return CMD_TYPE_IMG;
            }
            if((type == "txt" || type == "js" || type == "cs" || type == "as" || type == "html" || type == "java" || type == "cpp" || type == "xml" || type == "json"))
            {
                return CMD_TYPE_TXT;
            }
            return CMD_TYPE_OTHER;
        }
        /**获取指定目录下的所有文件列表**/
        public static Dictionary<string, string> getFileList(string path, Dictionary<string, string> dir)
        {
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (FileInfo file in folder.GetFiles())
            {
                dir.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo fc in folder.GetDirectories())
            {
                getFileList(fc.FullName, dir);
            }
            return dir;
        }
        /**同步两个目录的文件**/
        public static void syncDir(string sourcePath, string targetPath, syncResult result)
        {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(sourcePath);
                foreach (FileInfo file in folder.GetFiles())
                {
                    if (checkFilter(file.Name, result)) continue;
                    if (!File.Exists(targetPath + file.Name) || !equalMd5(file.FullName, targetPath + file.Name))
                    {
                        if (!Directory.Exists(targetPath)) Directory.CreateDirectory(targetPath);
                        File.Delete(targetPath + file.Name);
                        File.Copy(file.FullName, targetPath + file.Name);
                        result.syncList += file.FullName + "   >>>   " + targetPath + file.Name + "\r\n";
                        result.syncNum++;
                    }
                }
                foreach (DirectoryInfo folderChild in folder.GetDirectories())
                {
                    if (checkFilter(folderChild.Name, result)) continue;
                    syncDir(folderChild.FullName + "/", targetPath + folderChild.Name + "/", result);
                }
            }
            catch (Exception err)
            {
                result.result = false;
                result.errMsg = err.Message;
            }
        }
        private static bool checkFilter(string name, syncResult sr)
        {
            if (sr.filter == null) return false;
            foreach (string str in sr.filter)
            {
                if (name == str) return true;
            }
            return false;
        }
        /**比较两个文件MD5是否一致**/
        public static bool equalMd5(string source, string target)
        {
            return getMd5(source).Equals(getMd5(target));
        }
        /**获取指定文件的MD5**/
        public static string getMd5(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "xxx";
                //throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
    }
}

class syncResult
{
    public bool result = true;
    public int syncNum = 0;
    public string syncList = "";
    public string errMsg = "";
    public string[] filter;
}
