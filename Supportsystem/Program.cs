using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supportsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "Data.xml";

            List<Object> objects = Read(filename);

            MachineCatalogue mc = (MachineCatalogue) objects.ElementAt(0);
            Ticketoverview to = (Ticketoverview) objects.ElementAt(1);
            while (true)
            {
                string n1 = Console.ReadLine();
                if (n1.Equals("quit")) break;
                string n2 = Console.ReadLine();
                string n3 = Console.ReadLine();

                mc.AddMachine(new Machine(n1, n2, n3));

            }

            PrintMachines(mc);

            Write(objects, filename);

            Console.ReadLine();
        }

        public static bool Write(List<Object> objects , string filename)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Object>), new Type[] { typeof(MachineCatalogue), typeof(Ticketoverview) });
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, objects);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static List<Object> Read(String filename)
        {
            List<Object> objects = new List<Object>() { new MachineCatalogue(), new Ticketoverview() };
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Object>), new Type[] { typeof(MachineCatalogue), typeof(Ticketoverview) });
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    objects = (List<Object>)x.Deserialize(fs);

                return objects;
            }
            catch
            {

                return objects;
            }
        }
        public static void PrintMachines(MachineCatalogue mc)
        {
            foreach(Machine machine in mc.GetCopy())
            {
                Console.WriteLine(machine.ToString());
            }
        }
    }
}
