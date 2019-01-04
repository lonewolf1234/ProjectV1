using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Models
{
    public partial class DataPath
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ArchName { get; set; }

        public List<Port> Porto { get; set; }

    }
}
