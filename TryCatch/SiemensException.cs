using System;
namespace TryCatch
{
    public class SiemensFormatException : FormatException
    {
        public override string Message => "Format hatası meydana geldi!";
    }
}
