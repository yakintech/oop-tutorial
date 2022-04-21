using System;
using System.Collections.Generic;

namespace CSharpInterfaceSample
{
    public class EMailLogger : ILogger
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
