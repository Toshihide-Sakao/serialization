using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Items items = new Items();
            items.bruInt = 1;
            items.bruh = "bru";

            XmlSerializer serializer = new XmlSerializer(typeof(Items)); 
            FileStream saveFile = File.Open("Items.xml", FileMode.OpenOrCreate);
            serializer.Serialize(saveFile, items);
            saveFile.Close();

            saveFile = File.Open("Items.xml", FileMode.OpenOrCreate);
            items = (Items) serializer.Deserialize(saveFile);
            saveFile.Close();

            Console.WriteLine(items.bruInt);
            Console.ReadLine();
        }
    }
}
