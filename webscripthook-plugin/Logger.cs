﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebScriptHook
{
    class Logger
    {
        public static bool Enable = false;

        public static void Log(object message)
        {
            if (Enable)
            {
                File.AppendAllText(@".\scripts\WebScriptHook.log", DateTime.Now + " : " + message + Environment.NewLine);
            }
        }
    }
}
