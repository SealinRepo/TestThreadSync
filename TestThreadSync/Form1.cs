using common;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThreadSync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.GotFocus += txtVIew_Onfocus;
        }

        private void txtVIew_Onfocus(object o, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * None
             * Volatile
             * Lock
             * InterLocked
             * Monitor
             * Mutex
             * ReaderWriterLock
             * SynchronizationAttribute
             * MethodImplAttribute
             * AutoResetEvent
             * ManualResetEvent
             * */
            Control.CheckForIllegalCrossThreadCalls = false;
            if (comboBox1.SelectedIndex != 0)
            {
                Task.Factory.StartNew(() =>
                {
                    Type t = Type.GetType(string.Format("common.{0}Test,common", comboBox1.Text));
                    ISyncType o = Activator.CreateInstance(t) as ISyncType;
                    o.doWork(textBox1);
                });
            }
        }
    }
}
