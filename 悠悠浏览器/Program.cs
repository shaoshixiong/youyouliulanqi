using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace 悠悠浏览器
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //bool createNew;
            //using (System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            //{
            //    if (createNew)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new frmMain(args));
            //    }
            //    else
            //    {
            //        m.
            //     new    frmMain(null).fm.Add(args);                  
            //    }
           // }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new 主页面(args));
            //System.Diagnostics.Process instance = RunningInstance();
            //if (instance == null)
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new frmMain(args));
            //}
            //else
            //{
            //    HandleRunningInstance(instance);
            //}
        }
        /// <summary>
        /// 如果有另一个同名进程启动,则调用之前的实例
        /// </summary>
        /// <param name="instance"></param>
        private static void HandleRunningInstance(Process instance)
        {
        }
        /// <summary>
        /// 获取当前正在运行的进程实例
        /// </summary>
        /// <returns></returns>
        public static Process RunningInstance()
        {
            // 获取当前活动的进程
            Process current = Process.GetCurrentProcess();
            // 获取当前本地计算机上指定的进程名称的所有进程
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                // 忽略当前进程
                if (process.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }

            // 如果没有其他同名进程存在,则返回 null
            return null;
        }
    }
}
