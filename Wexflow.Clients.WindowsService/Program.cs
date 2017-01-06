﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Reflection;
using System.Threading;

namespace Wexflow.Clients.WindowsService
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].Equals("debug"))
            {
                WexflowWindowsService service = new WexflowWindowsService();
                service.OnDebug();
                Thread.Sleep(Timeout.Infinite);
            }
            else
            {
                ServiceBase[] servicesToRun;
                servicesToRun = new ServiceBase[] { new WexflowWindowsService() };
                ServiceBase.Run(servicesToRun);
            }
        }

    }
}
