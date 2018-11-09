using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator.Classes
{
    class Signal
    {
        public string Name { get; set; }

        public bool Bus { get; set; }

        public int MSB { get; set; }

        public int LSB { get; set; }
    }
}
