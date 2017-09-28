using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace common
{
    public class VolatileTest : SyncTypeController
    {
        volatile int j = 0;
        protected override void threadRun()
        {
            i = ++j;
            base.threadRun();
        }
    }
}
