using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class FileConsoleReader
    {

        public string ReadFileTxt(string fileName)
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string output = String.Empty;
            byte[] buf = new byte[1024];
            int c;

            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            var path = currentDirectory + "\\..\\..\\.." + "\\" + fileName;


            try
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                {
                    output += Encoding.UTF8.GetString(buf, 0, c);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return output;
        }
    }
}
