using System;
namespace CSharpGameInterfaceSample
{
    public class GameManager
    {

        public void WarmProcess(IWarm warm)
        {
            warm.Defence();
            warm.Attack();
        }

    }
}
