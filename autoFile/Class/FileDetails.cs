using System.IO;

namespace ppqq
{
    class FileDetails
    {
        public string fullName = "";
        public string path = "";
        public string name = "";
        public string type = "";
        public FileDetails(string url)
        {
            fullName = url;
            if (Directory.Exists(url))
            {
                path = url;
            }
            else {
                path = url.Substring(0, url.LastIndexOf("\\") + 1);
                if (url.LastIndexOf(".") < 0) name = type = "";
                else {
                    int l = url.LastIndexOf(".") - url.LastIndexOf("\\") - 1;
                    l = l < 0 ? 0 : l;
                    name = url.Substring(url.LastIndexOf("\\") + 1, l);
                    type = url.Substring(url.LastIndexOf("."));
                }
            }
        }
    }
}