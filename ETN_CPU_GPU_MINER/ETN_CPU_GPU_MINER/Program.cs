﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETN_CPU_GPU_MINER
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool m_bAutoRun = false;
        public static bool m_bMinimize = false;
        public static bool m_bDoLog = true;
        private static bool m_bHasMaxRuntime = false;
        public static double m_dMaxRuntime = 0.00;

        [STAThread]
        static void Main(string[] args)
        {
            foreach (string sArg in args)
            {
                if (sArg.ToLower().Equals("-autorun"))
                    m_bAutoRun = true;

                if (sArg.ToLower().Equals("-minimize"))
                    m_bMinimize = true;

                if (sArg.ToLower().Equals("-nolog"))
                    m_bDoLog = false;

                if (sArg.ToLower().Equals("-maxuptime"))
                    m_bHasMaxRuntime = true;

                if (m_bHasMaxRuntime && !sArg.ToLower().Equals("-maxuptime")
                    && !sArg.ToLower().Equals("-nolog") && !sArg.ToLower().Equals("-minimize")
                    && !sArg.ToLower().Equals("-autorun"))
                    m_dMaxRuntime = Convert.ToDouble(sArg);

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
