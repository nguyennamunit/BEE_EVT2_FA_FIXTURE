using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE_EVT2_FA_FIXTURE.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TestPoint { get; set; }
        public string LowLimit { get; set; }
        public string HighLimit { get; set; }
        public string Value { get; set; }
        public string Result { get; set; } 
    }
}
