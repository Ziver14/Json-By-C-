using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_By_C_
{
    public class JsonHelper
    {
        public static string SerializeObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj,Formatting.Indented);
        }

        public static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void SaveToFile<T>(string Filepath, T obj)
        {
            var json = SerializeObject(obj);
            File.WriteAllText(Filepath, json);
        }

        public static T LoadFromFile<T>(string filepath)
        {
            var json = File.ReadAllText(filepath);
            return DeserializeObject<T>(json);
        }
    }
}
