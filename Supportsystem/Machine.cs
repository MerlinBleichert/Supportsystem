using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supportsystem
{
    [Serializable]
    public class Machine
    {
        private string _comnumber;
        private string _customer;
        private string _location;

        public Machine(string newComnumber, string newCustomer, string newLocation)
        {
            this._comnumber = newComnumber;
            this._customer = newCustomer;
            this._location = newLocation;
        }

        public string Comnumber
        {
            get { return this._comnumber; }
            set { this._comnumber = value; }
        }

        public string Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        public override string ToString()
        {
            return Comnumber +" "+ Customer +" "+ Location;
        }


        public Machine()
        {

        }


    }
}
