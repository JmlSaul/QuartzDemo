using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using Quartz.Simpl;
using Quartz.Xml;

namespace QuartzDemoWithConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            //var commonLog = Common.Logging.LogManager.GetLogger("logging");
            //初始化log4net配置
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));

            var log = log4net.LogManager.GetLogger("fileLog");

            log.Info("starting program...");
            ISchedulerFactory factory = new StdSchedulerFactory();
            var scheduler = factory.GetScheduler();
            log.Info("shceduler got...");
            scheduler.Start();
            log.Info("scheduler starting...");
            Console.ReadKey();
            log.Info("scheduler shutting down...");
            scheduler.Shutdown();
            log.Info("shceduler shutdown completed...");
            Console.ReadKey();
        }
    }
}
