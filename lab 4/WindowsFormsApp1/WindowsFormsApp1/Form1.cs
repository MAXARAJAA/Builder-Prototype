using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var monitorBuilder = new MonitorBuilder();

            if (radioButton1.Checked) 
            {
                monitorBuilder.SetPanelType("TN");
                MessageBox.Show("Тип панелі twisted nematic");
            }
            if (radioButton2.Checked)
            {
                monitorBuilder.SetPanelType("VA");
                MessageBox.Show("Тип панелі vertical alignment");
            }

            if(radioButton4.Checked)
            {
                monitorBuilder.SetSize("15.6");
                MessageBox.Show("У монітора 15.6 дюйм");
            }
            if (radioButton5.Checked) 
            {
                monitorBuilder.SetSize("30");
                MessageBox.Show("У монітора 30 дюйм");
            }
            int refreshRate = 144;
            if (radioButton6.Checked)
            {
                monitorBuilder.SetRefreshRate(refreshRate);
                MessageBox.Show("У монітора" + refreshRate +"GHz");
            }
            if (radioButton7.Checked)
            {
                monitorBuilder.SetRefreshRate(refreshRate);
                MessageBox.Show("У монітора " + refreshRate + "GHz");
            }
            
            var monitor = monitorBuilder.GetMonitor();
            var monitorImage = GetMonitorImage(monitor);

            var copy = monitor.DeepCopy();
            var monitorImages = CopyMonitor(copy);
        }
        private Image GetMonitorImage(Monitor monitor)
        {
            if (monitor.RefreshRate == 144)
            {
                return pictureBox1.Image = Resource1._144;
            }
            else
            {
                return pictureBox1.Image = Resource1._120;
            }
        }

        private Image CopyMonitor(Monitor copy)
        {
            if (copy.RefreshRate == 144)
            {
                return pictureBox2.Image = Resource1._144;
            }
            else
            {
                return pictureBox2.Image = Resource1._120;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }     
}
