using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Domain
{
    public class Presentation
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Type { get; set; }
        public String Abstract { get; set; }
        public List<Speaker> Speaker {get; set;}
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
