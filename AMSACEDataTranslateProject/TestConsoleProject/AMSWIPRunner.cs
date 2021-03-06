﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMSDCMDataTranslator.Models;
using AMSDCMDataTranslator;


namespace TestConsoleProject
{
    public class AMSWIPRunner
    {
        public static void Run()
        {
            WIPSetting.SetValue();
            WIPRunner.RunAmsWIP();
        }


        public static void Run(string[] args)
        {
            if (args.Length > 0)
            {
                DateTime from = new DateTime();
                DateTime to = new DateTime();
                bool isYes = DateTime.TryParseExact(args[0], "yyyy-MM-dd-HH.mm.ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out from);

                if (args.Length == 1)
                {
                    to = DateTime.Now;
                }
                else if (args.Length == 2)
                {
                    isYes &= DateTime.TryParseExact(args[1], "yyyy-MM-dd-HH.mm.ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out to);
                }
                else
                {
                    Console.WriteLine("Usage:AMSWIPRunner from to[default now]");
                    return;
                }

                if (!isYes)
                {
                    Console.WriteLine("正确的时间格式：yyyy-MM-dd-HH.mm.ss");
                    return;
                }
                WIPSetting.SetValue();
                WIPRunner.RunAmsWIP(from, to,false);
            }
            else
            {
                WIPSetting.SetValue();
                WIPRunner.RunAmsWIP();
            }
            //休息500ms用于确保log记录
            System.Threading.Thread.Sleep(500);
        }
    }
}
