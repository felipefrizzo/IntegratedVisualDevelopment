using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLayers.Code.DTO {
    class ClientDTO {
        private string name;
        private string birthday;
        private string phone;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Birthday {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Phone {
            get { return phone; }
            set { phone = value; }
        }
    }
}
