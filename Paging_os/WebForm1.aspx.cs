using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace Paging_os
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public double calc(double ram, double frame)
        {
            try
            {
                return ram / frame;
            }
            catch
            {
                return 0;
            }
        }

        int[] page;
        int[] chance;
        int fault = 0;
        int[] second;

        public void secondchance(int frame)
        {
            second = new int[frame];
            for (int i = 0; i < frame; i++)
            {
                second[i] = 0;
            }


                chance = new int[frame];
            bool flag = false;
            for(int i = 0; i<page.Length;i++)
            {
                
                ListBox1.SelectedIndex=i;
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                if(!chance.Contains(page[i]))
                {
                    fault ++;
                    for (int k = 0; k < frame; k++)
                    {
                        if (second[k] > 0 && second[k]!=0)
                        {
                            second[k]--;
                        }
                        else if(second[k]==0 && !flag)
                        {
                            flag = true;
                            chance[k] = page[i];
                        }
                    }
                    flag = false;
                }
                else
                {
                    second[Array.IndexOf(chance,page[i])]++;
                }

                for(int l = 0; l < page.Length-1; l++)
                {
                    try
                    {
                        ListBox2.Items.Add(chance[l].ToString());
                        ListBox3.Items.Add(second[l].ToString());
                    }
                    catch
                    { }
                }
                //Thread.Sleep(500);
            }
        }

        public void paging(int frame)
        {
            page = new int[frame*3];
            Random r = new Random();
            for(int i =0;i<frame*3;i++)
            {
                page[i] = r.Next(9)+1;
                ListBox1.Items.Add(page[i].ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            double frames = calc(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
            Label1.Text = "Amount of frames: " + (Math.Floor(frames)).ToString();
            paging(Convert.ToInt32(frames));
            secondchance(Convert.ToInt32(frames));
        }
    }
}