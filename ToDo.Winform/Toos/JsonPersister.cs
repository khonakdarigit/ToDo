using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Winform.Toos
{
    internal class JsonPersister
    {
        public void Serialize<T>(string fileName, T value)
        {
            File.WriteAllText(fileName, Newtonsoft.Json.JsonConvert.SerializeObject(value));

            //JsonSerializer jsonSerializer = new JsonSerializer();
            //using (StreamWriter streamWriter = new StreamWriter(fileName))
            //using (JsonWriter jsonTextWriter = new JsonTextWriter(streamWriter))
            //{

            //    jsonSerializer.Serialize(jsonTextWriter, value);
            //}
        }

        public T Deserialize<T>(string fileName)
        {
            string jsonString=File.ReadAllText(fileName);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString);

            //JsonSerializer jsonSerializer = new JsonSerializer();

            //using (StreamReader streamReader = new StreamReader(fileName))
            //using (JsonReader jsonReader = new JsonTextReader(streamReader))
            //{
            //    return jsonSerializer.Deserialize<T>(jsonReader);
            //}
        }
    }
}
