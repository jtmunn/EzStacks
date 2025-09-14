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

        var nodes = doc.SelectNodes("//property[@name='Stacknumber']");
        if (nodes != null)
        {
            foreach (var node in nodes)
            {
                if (node is XmlElement el)
                {
                    el.SetAttribute("value", "50000");
                }
            }
        }

        doc.Save(path);
    }
}


