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
            string path = "C://all you need is//to study//ООП//6lab//feed-test.xml";
            try
            {
                int male = 0;
                int female = 0;
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    bool rightCity = false;
                    
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "city")
                        

                        if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "user")
                        {

                        }
                    }
                    
                }
                Console.WriteLine("male: {0}, female: {1}", male, female);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
