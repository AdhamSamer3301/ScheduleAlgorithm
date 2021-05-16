
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Btn_Click(object sender, EventArgs e)
        {
            reset();
            int numbers = Int32.Parse(ProcessTime_TxtBox.Text);
            FCFS fCFS = new FCFS(numbers);
            int[] burstTime = fCFS.getBrustTime();
            int[] waitingTime = fCFS.getWaitingTime();
            int[] turnAroundTime = fCFS.getTurnAroundTime();
            for (int i = 0; i < numbers; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(burstTime[i].ToString());
                item.SubItems.Add(waitingTime[i].ToString());
                item.SubItems.Add(turnAroundTime[i].ToString());
                listView1.Items.Add(item);
            }

            foreach (var proc in fCFS.getGranttChart())
            {
                GanttChart.Series["GanttChart"].Points.AddXY(proc.Key, proc.Value);
            }

            NumberFormatInfo setPrecision = new NumberFormatInfo();

            setPrecision.NumberDecimalDigits = 2;
            AvgWTTime_Label.Text = fCFS.getAvgWaitingTime().ToString("N", setPrecision);
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            reset();
            ProcessTime_TxtBox.Clear();
        }
        private void reset()
        {
            listView1.Items.Clear();
            AvgWTTime_Label.Text = "";
            GanttChart.Series["GanttChart"].Points.Clear();
        }
    }
}
