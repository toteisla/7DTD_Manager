using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DTD_Manager
{
    class Player
    {
        private string name;
        private string id;

        public string Name
        {
            get { return this.name; }
            set { this.name = value;  }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value;  }
        }
    }
}
