using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCGRecon.Forms;

namespace DCGRecon.Recon
{
    public class Log
    {
        public Debugfrm formdebug;

        public static void LogMessage(string filesource, string logtext)
        {
        }

        public void LogMessage(string logtext)
        {
            Log.LogMessage("application", logtext);
            Trace.WriteLine(logtext);
            if (this.formdebug == null)
                return;
            this.formdebug.AddLogEntry(logtext);
        }

        public static void LogMessageStatic(string logtext)
        {
            Log.LogMessage("application", logtext);
            Trace.WriteLine(logtext);
        }

        public void ShowDebug()
        {
            this.formdebug = new Debugfrm();
            this.formdebug.Show();
        }
    }
}
