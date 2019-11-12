using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServicePraf
{
    public partial class WinService : ServiceBase
    {
        public WinService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("WinService"))
            {
                EventLog.CreateEventSource("WinService", "Application");
            }
            eventLog1.Source = "WinService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Starting the service", EventLogEntryType.Information, 1001);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopping the service", EventLogEntryType.Information, 1001);
        }
    }
}
