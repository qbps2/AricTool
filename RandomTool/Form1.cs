using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTool
{
    public partial class Form1 : Form
    {

        ConfigInfo configInfo = new ConfigInfo();
        public Form1()
        {
            InitializeComponent();
            configInfo = ConfigClass.OpenConfig("config.json");
            textBoxMin.Text = configInfo.MinValue.ToString();
            textBoxMax.Text = configInfo.MaxValue.ToString();
            textBoxCount.Text = configInfo.Count.ToString();
            checkBoxRepeatable.Checked = configInfo.Repeatable;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            { 
                configInfo.MinValue = int.Parse(textBoxMin.Text);
                configInfo.MaxValue = int.Parse(textBoxMax.Text);
                configInfo.Count = int.Parse(textBoxCount.Text);
                configInfo.Repeatable = checkBoxRepeatable.Checked;
                configInfo.Sort = checkBoxSort.Checked;

                if(configInfo.MinValue > configInfo.MaxValue)
                {
                    MessageBox.Show("error, MinValue > MaxValue");
                    return;
                }

                if(configInfo.Count < 0)
                {
                    MessageBox.Show("error, count < 0");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
                return;
            }

            textBoxResult.Text = "";

            var rand = new Random();
            int [] Values;

            int Count = 0;
            if(configInfo.Repeatable == false)
            { 
                if((configInfo.MaxValue - configInfo.MinValue +1) < configInfo.Count)
                {
                    Count = configInfo.MaxValue - configInfo.MinValue + 1;
                }
                else
                {
                    Count = configInfo.Count;
                }

                Values = new int [Count];
                for(int i = 0; i < Count ; i++)
                {
                    Values[i] = rand.Next(configInfo.MinValue, configInfo.MaxValue + 1);
                    for(int j = 0; j < i; j++)
                    {
                        while(Values[j] == Values[i])
                        {
                            j = 0;
                            Values[i] = rand.Next(configInfo.MinValue, configInfo.MaxValue + 1);
                        }
                    }
                }
            }
            else
            {
                Count = configInfo.Count;
                Values = new int [Count];
                for(int i = 0; i < Count; i++)
                {
                    Values[i] = rand.Next(configInfo.MinValue, configInfo.MaxValue + 1);
                }
            }

            if(configInfo.Sort == true)
            {
                Array.Sort(Values);
            }


            textBoxResult.Text = DateTime.Now.ToString("MM/dd") + "\r\n\r\n";
            for(int i = 0 ; i < Count ; i++)
            {
                textBoxResult.Text = textBoxResult.Text + Values[i].ToString() + " ";
            }

            ConfigClass.SaveConfig(configInfo, "config.json");
        }
    }
}
