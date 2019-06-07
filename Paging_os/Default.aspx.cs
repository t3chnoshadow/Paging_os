using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using System.Management;
//using System.Management.ManagementOptions;

namespace Paging_os
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("IExplore.exe", "http://efundi.nwu.ac.za/portal/");
            Label1.Text = "State: Running Process";
            Process p = Process.Start(AppDomain.CurrentDomain.BaseDirectory+ "\\Test_Files\\math\\math\\bin\\Debug\\math.exe");
            //Process p = Process.Start(AppDomain.CurrentDomain.BaseDirectory+"//Test_Files//Test2.txt");
            PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", p.ProcessName);
            PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
            
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                double ram = ramCounter.NextValue();
                double cpu = cpuCounter.NextValue();
                TextBox2.Text = ("RAM: " +( Math.Round((ram / 1024 / 1024),2)).ToString() + " MB; CPU: " + (Math.Round(cpu)).ToString() + " %");
            }
            p.Dispose();
            Label1.Text = "State: Checking System";
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;
            ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
            scope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            foreach (ManagementObject queryObj in searcher.Get())
            {
               // System.Diagnostics.Debug.WriteLine("-----------------------------------");
                TextBox3.Text="Capacity: "+ (Convert.ToInt64(queryObj["Capacity"])/1024/1024).ToString()+"MB";
                TextBox3.Text+=" ; MemoryType: "+ GetMemoryType(Int32.Parse(queryObj["MemoryType"].ToString()));

            }
            Label1.Text = "State: Done";
        }

        public string GetMemoryType(int MemoryType)
        {
            switch (MemoryType)
            {
                case 20:
                    return "DDR";
                    break;
                case 21:
                    return "DDR-2";
                    break;
                case 22:
                    return "DDR-3";
                    break;
                default:
                    if (MemoryType == 0 || MemoryType > 23)
                        return "DDR-4";
                    else
                        return "Other";
                    break;//https://www.codeproject.com/Questions/453202/How-to-check-type-of-RAM

            }
        }
    }
}