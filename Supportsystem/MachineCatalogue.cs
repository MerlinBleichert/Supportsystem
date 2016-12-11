using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supportsystem
{
    [Serializable]
    public class MachineCatalogue
    {
        private List<Machine> machines = new List<Machine>();
        public MachineCatalogue()
        {

        }

        public MachineCatalogue(List<Machine> machines)
        {
            this.machines = machines;
        }

        public void AddMachine(Machine machine)
        {
            if (!this.machines.Contains(machine))
            {
                machines.Add(machine);
            }
        }

        public List<Machine> GetCopy()
        {
            return new List<Machine>(machines);
        }
    }
}
