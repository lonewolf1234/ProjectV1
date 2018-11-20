using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Models
{
    class Component
    {
        public Component() { }

        public int ID { get; set; }

        public string Name { get; set; }

        public string ArchName { get; set; }

        public List<Port> Ports { get; set; }
    }
}
