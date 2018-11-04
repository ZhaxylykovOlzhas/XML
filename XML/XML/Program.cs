using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
                XmlDocument xml = new XmlDocument();
                xml.Load("C:\\Users\\Олжас\\Desktop\\XmlAndJson-master\\XmlJson\\XmlJson\\Students.xml");

            foreach (XmlNode task in xml.DocumentElement.ChildNodes)
                {
                        foreach (XmlNode param in task.ChildNodes)
                        {
                            Console.WriteLine(param.InnerText);
                        }
                }
                Console.ReadLine();
        }
    }
}
