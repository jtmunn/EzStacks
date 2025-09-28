using System;
using System.Linq;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            throw new InvalidOperationException("Expected exactly one argument: path to input file 'items.xml'.");
        }

        var path = args[0];

        var doc = new XmlDocument
        {
            PreserveWhitespace = true // preserve comments/formatting
        };
        doc.Load(path);

        var stackNodes = doc.SelectNodes("//property[@name='Stacknumber']");
        if (stackNodes != null)
        {
            foreach (XmlNode stackNode in stackNodes)
            {
                if (stackNode is XmlElement stackEl)
                {
                    var parent = stackEl.ParentNode;
                    if (parent != null)
                    {
                        var tagsNode = parent.SelectSingleNode("property[@name='Tags']");
                        bool containsVehicle = false;

                        if (tagsNode is XmlElement tagsEl)
                        {
                            var tagsValue = tagsEl.GetAttribute("value");
                            var tags = tagsValue.Split(',').Select(t => t.Trim());
                            containsVehicle = tags.Contains("vehicle");
                        }

                        if (!containsVehicle)
                        {
                            stackEl.SetAttribute("value", "50000");
                        }
                    }
                }
            }
        }

        doc.Save(path);
    }
}
