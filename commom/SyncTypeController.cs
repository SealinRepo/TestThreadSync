using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace common
{
    public class SyncTypeController : ISyncType
    {
        protected int i = 0;
        protected TextBox tbx;
        public void doWork(TextBox tbx)
        {
            this.tbx = tbx;
            tbx.Clear();
            ThreadStart ts = new ThreadStart(threadRun);
            for (int j = 0; j < 20; j++)
            {
                Thread t = new Thread(ts);
                t.Name = "Thread-" + j;
                t.Start();
            }
        }

        protected virtual void threadRun()
        {
            tbx.AppendText(string.Format("{0}: i = {1}{2}", Thread.CurrentThread.Name, i, Environment.NewLine));
        }
    }
}
