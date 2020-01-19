using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inv.Models
{
    public class product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime day_received { get; set; }
        
        
        public string Hardware { get; set; }
        public string serial_number { get; set;  }
        public string state { get; set;  }
        public bool contract { get; set;  }
    }
}
