using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BudgetAccounting
{
    public class DeserAndSer
    {
        private static readonly string DesktopFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static T Serialization<T>(string fileName)
        {
            var filePath = Path.Combine(DesktopFolderPath, fileName);
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void Deserialization<T>(T entries, string fileName)
        {
            var filePath = Path.Combine(DesktopFolderPath, fileName);
            var json = JsonConvert.SerializeObject(entries);
            File.WriteAllText(filePath, json);
        }
    }
}
