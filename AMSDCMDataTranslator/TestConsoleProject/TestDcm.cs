﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMSDCMDataTranslator.Helper;
using AMSDCMDataTranslator.Models;
using AMSDCMDataTranslator;

namespace TestConsoleProject
{
   public class TestDcm
    {
        public static void Test()
        {
            DCMSetting.SetValue();
            DCMRunner.Run();
        }
    }
}
