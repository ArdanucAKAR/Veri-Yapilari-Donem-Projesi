using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    class TextReader
    {
        public static String Path { get; set; }
        public static object Data { get; set; }

        public static BinaryTree ReadFile()
        {
           string file = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName + Path;
            return JsonConvert.DeserializeObject<BinaryTree>(File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")));
        }
    }
}
