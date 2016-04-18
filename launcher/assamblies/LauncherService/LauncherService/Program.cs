using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

// внешние зависимости
using form;
using Updater;

namespace LauncherService
{
    static class Program
    { 
        static void Main()
        {

            FormWorker formWorker = new FormWorker();
            formWorker.OpenForm();

          /*  LauncherUpdater lu = new LauncherUpdater();

            lu.CheckUpdates();*/

           /* ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);*/
        }
    }
}
