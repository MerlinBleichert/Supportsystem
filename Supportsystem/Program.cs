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

            ModelObjects objects = Read(filename);

            MachineCatalogue mc = objects.MachineCa;
            Ticketoverview to =objects.TicketOV;
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

        public static bool Write(ModelObjects objects , string filename)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(ModelObjects));
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, objects);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static ModelObjects Read(String filename)
        {
            ModelObjects objects = new ModelObjects();
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(ModelObjects));
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    objects = (ModelObjects)x.Deserialize(fs);

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
