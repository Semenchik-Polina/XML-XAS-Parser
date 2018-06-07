using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\all you need is\to study\ООП\6lab\feed.xml";
            Console.WriteLine("Please enter city name");

            try
            {
                //    string temp = Console.ReadLine();
                //    string[] city;
                string city = Console.ReadLine();
                int maleCount = 0;
                int femaleCount = 0;
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    bool rightCity = false;
                    bool inGender = false;
                    bool inCity = false;
                    
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "city")
                            inCity = true;

                        if (inCity && reader.NodeType == XmlNodeType.Text && reader.Value == city)
                            rightCity = true;
                        
                        if (rightCity && reader.NodeType == XmlNodeType.Element && reader.LocalName == "gender")
                            inGender = true;

                        if (reader.NodeType == XmlNodeType.Text && inGender)
                        {
                            if (reader.Value == "male")
                                maleCount++;
                            if (reader.Value == "female")
                                femaleCount++;
                        }

                        if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "user")
                        {
                            rightCity = false;
                            inCity = false;
                            inGender = false;
                        }
                    }
                    
                }
                Console.WriteLine("male: {0}, female: {1}", maleCount, femaleCount);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
