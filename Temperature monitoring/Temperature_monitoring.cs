using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_monitoring
{
    public partial class TemperatureMonitoring : Form
    {
        public FishList fish;
        string name, maxTemp, maxTime, minTemp, minTime, date, temp;
        public TemperatureMonitoring()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = sender.ToString();
        }

        private void textBoxMaxTemp_TextChanged(object sender, EventArgs e)
        {
            maxTemp = sender.ToString();
        }

        private void textBoxMaxTime_TextChanged(object sender, EventArgs e)
        {
            maxTime = sender.ToString();
        }

        private void textBoxMinTemp_TextChanged(object sender, EventArgs e)
        {
            minTemp = sender.ToString();
        }

        private void textBoxMinTime_TextChanged(object sender, EventArgs e)
        {
            minTime = sender.ToString();
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            date = sender.ToString();
        }

        private void textBoxTemp_TextChanged(object sender, EventArgs e)
        {
            temp = sender.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "TXT(*.TXT)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fish.Save(saveFileDialog.FileName);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TXT(*.TXT)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fish.Load(openFileDialog.FileName);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {

        }
    }
}
