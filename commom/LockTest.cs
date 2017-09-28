using System;
using System.Threading;
using System.Windows.Forms;

namespace common
{
    public class LockTest : SyncTypeController
    {
        private object oLock = new object();

        protected override void threadRun()
        {
            lock (oLock)
            {
                i++;
                base.threadRun();
            }
        }
    }
}
