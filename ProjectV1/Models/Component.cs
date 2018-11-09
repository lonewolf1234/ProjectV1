using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator.Classes
{
    class Component
    {
        public string Name { get; set; }

        public string ArchName { get; set; }

        public List<Port> Ports { get; set; }
    }
}
