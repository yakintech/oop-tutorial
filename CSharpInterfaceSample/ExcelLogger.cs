using System;
using System.Collections.Generic;

namespace CSharpInterfaceSample
{
    public class ExcelLogger : ILogger, IOfficeConf
    {
        public void OfficeLogin(string name, string password)
        {
          
        }

        public List<Log> ReadLog()
        {
            throw new NotImplementedException();
        }

        public void WriteLog(List<Log> logs)
        {
           
        }
    }
}
