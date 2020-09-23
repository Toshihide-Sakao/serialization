using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            powerUp p = new powerUp();
            p.bruh = 1;
            p.bruhstring = "bru";

            XmlSerializer serializer = new XmlSerializer(typeof(powerUp)); 

            FileStream saveFile = File.Open("powerUp.xml", FileMode.OpenOrCreate);

            p = (powerUp) serializer.Deserialize(saveFile);
            saveFile.Close();

            System.Console.WriteLine(p.bruhstring);
            Console.ReadLine();
        }
    }
}
