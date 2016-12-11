using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    [Serializable]
    public class ModelObjects
    {
        private MachineCatalogue mc = new MachineCatalogue();
        private Ticketoverview to = new Ticketoverview();

        public ModelObjects()
        {

        }

        public ModelObjects(MachineCatalogue mc, Ticketoverview to)
        {
            this.MachineCa = mc;
            this.TicketOV = to;
        }

        public MachineCatalogue MachineCa
        {
            get
            {
                return mc;
            }

            set
            {
                mc = value;
            }
        }

        public Ticketoverview TicketOV
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }
    }
}
