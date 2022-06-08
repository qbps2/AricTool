using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStringProject
{
    public class ConfigInfo
    {
        [JsonProperty(Order = 0)]

        public List<SearchSetting> ListSearchSettings { get;set;}
        //public string SearchString1 { get; set; }
        //[JsonProperty(Order = 1)]
        //public string SearchString2 { get; set; }
        //[JsonProperty(Order = 2)]
        //public string SearchString3 { get; set; }

        [JsonProperty(Order = 1)]
        public bool IsShowLine { get;set;}

        [JsonProperty(Order = 2)]
        public bool IsMultiResult { get;set;}

        [JsonProperty(Order = 3)]
        public string LastPath { get; set; }

        public ConfigInfo()
        {
            ListSearchSettings = new List<SearchSetting>();
        }
    }

    public class SearchSetting
    { 
        public string SearchString { get;set;}
        public bool IsPrintLine { get;set;}
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
                configInfo.ListSearchSettings.Add( new SearchSetting{ SearchString = "abc", IsPrintLine = true });
                configInfo.IsShowLine = true;
                configInfo.IsMultiResult = false;

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
