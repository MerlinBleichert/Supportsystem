using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class Ticketoverview
    {
        private List<Ticket> tickets = new List<Ticket>();

        public Ticketoverview()
        {

        }

        public Ticketoverview(List<Ticket> tickets)
        {
            this.tickets = tickets;
        }

        public void AddTicket(Ticket ticket)
        {
            if (!this.tickets.Contains(ticket))
            {
                this.tickets.Add(ticket);
            }
        }

        public List<Ticket> GetNewList(Boolean solved)
        {
            List<Ticket> newList = new List<Ticket>();

            foreach(Ticket ticket in this.tickets)
            {
                if(ticket.Solved == solved)
                {
                    newList.Add(ticket);
                }

            }

            return newList;
        }
        public List<Ticket> GetSolved()
        {
            return GetNewList(true);
        }

        public List<Ticket> GetUnsolved()
        {
            return GetNewList(false);
        }

    }
}
