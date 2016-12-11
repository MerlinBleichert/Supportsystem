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

            MachineCatalogue mc = Read(filename);

            while (true)
            {
                string n1 = Console.ReadLine();
                if (n1.Equals("quit")) break;
                string n2 = Console.ReadLine();
                string n3 = Console.ReadLine();

                mc.AddMachine(new Machine(n1, n2, n3));

            }

            PrintMachines(mc);

            Console.ReadLine();

            Console.WriteLine(Write(mc, filename));
            Console.ReadLine();
        }

        public static bool Write(MachineCatalogue mc, string filename)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(MachineCatalogue));
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, mc);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static MachineCatalogue Read(String filename)
        {
            MachineCatalogue mc = new MachineCatalogue();
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(MachineCatalogue));
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    mc = (MachineCatalogue)x.Deserialize(fs);

                return mc;
            }
            catch
            {
                
                return mc;
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
