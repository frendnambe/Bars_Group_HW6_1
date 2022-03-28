using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_Group_HW2
{
    namespace bars_group_6_1
    {
        public class LocalFileLogger<T> : ILogger
        {
            private string _path;
            private string _filename = "Log.txt";

            public LocalFileLogger(string path)
            {
                _path = path + Path.DirectorySeparatorChar + _filename;
            }

            public void LogInfo(string mess)
            {
                File.AppendAllText(_path, $"[Info]    : [{typeof(T).Name}] : {mess}");
            }

            public void LogError(string mess, Exception ex)
            {
                File.AppendAllText(_path, $"[Error]   : [{typeof(T).Name}] : {mess}. {ex.Message}");
            }


            public void LogWarning(string mess)
            {
                File.AppendAllText(_path, $"[Warning] : [{typeof(T).Name}] : {mess} ");
            }
        }
    }
}
