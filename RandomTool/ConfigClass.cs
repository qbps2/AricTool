using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTool
{
    public class ConfigInfo
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Count { get; set; }
        public bool Repeatable { get; set; }
        public bool Sort { get;set;}
    }

    public class ConfigClass
    {
        public static ConfigInfo OpenConfig(string CONFIG_FILE)
        {
            ConfigInfo configInfo = new ConfigInfo();
            string configString;
            try
            {
                using (var streamReader = new StreamReader(CONFIG_FILE, Encoding.UTF8))
                {
                    configString = streamReader.ReadToEnd();
                    streamReader.Close();
                    configInfo = JsonConvert.DeserializeObject<ConfigInfo>(configString);
                }
            }
            catch (Exception)
            {
                configInfo.MinValue = 0;
                configInfo.MaxValue = 100;
                configInfo.Count = 1;
                configInfo.Repeatable = false;
                configInfo.Sort = false;
                configString = JsonConvert.SerializeObject(configInfo, Formatting.Indented);       //transform json format string
                StreamWriter streamWriter = new StreamWriter(CONFIG_FILE);    //save to config file
                streamWriter.WriteLine(configString);
                streamWriter.Close();
            }
            return configInfo;
        }

        public static void SaveConfig(ConfigInfo configInfo, string CONFIG_FILE)
        {
            string configString = JsonConvert.SerializeObject(configInfo, Formatting.Indented);
            StreamWriter streamWriter = new StreamWriter(CONFIG_FILE);        //save to config file
            streamWriter.WriteLine(configString);
            streamWriter.Close();
        }
    }
}
