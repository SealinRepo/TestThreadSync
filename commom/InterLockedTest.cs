using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace common
{
    public class InterLockedTest : SyncTypeController
    {
        volatile int j = 0;
        protected override void threadRun()
        {
            i = Interlocked.Increment(ref j);
            base.threadRun();
        }
    }
}
