using System;
using System.Collections.Generic;

namespace CSharpInterfaceSample
{
    public class DatabaseLogger : ILogger
    {
        public List<Log> ReadLog()
        {
            throw new NotImplementedException();
        }

        public void WriteLog(List<Log> logs)
        {
           
        }
    }
}
