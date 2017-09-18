using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Quartz;

namespace QuartzDemoWithConfig
{
    class Cron : IJob
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(typeof(Simple));
        public void Execute(IJobExecutionContext context)
        {
            log.Info("Cron");
            //Console.WriteLine("Cron");
        }
    }
}
