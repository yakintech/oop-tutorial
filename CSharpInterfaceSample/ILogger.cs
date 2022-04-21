using System;
using System.Collections.Generic;

namespace CSharpInterfaceSample
{
    public interface ILogger
    {
        void WriteLog(List<Log> logs);

        List<Log> ReadLog();
    }
}
