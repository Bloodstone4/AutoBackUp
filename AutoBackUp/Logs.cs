using System;
using System.Collections.Generic;
using System.Text;

namespace AutoBackUp
{
    public class Logs
    {
        public string DirectoryName { get; set; }
        public List<string> FilesList { get; set; }

        public long FilesSize { get; set; }

    }
}
