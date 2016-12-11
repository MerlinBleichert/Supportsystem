using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{   
    [Serializable]
    public class Ticket
    {
        private Boolean _solved = false;
        private string _name;
        private string _infos;

        public Ticket(string newName, string newInfos)
        {
            this._name = newName;
            this._infos = newInfos;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string Infos
        {
            get { return this._infos; }
            set { this._infos = value; }
        }

        public Boolean Solved
        {
            get { return this._solved; }
            set { this._solved = value; }
        }


    }
}
