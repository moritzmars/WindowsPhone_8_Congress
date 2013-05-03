using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Domain
{
    public class Session
    {
        public int ID { get; set; }
        public List<Moderator> Moderators { get; set; }
        public List<Presentation> Presentations { get; set; }
        public String Title { get; set; }
        public String Room { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public String SessionType { get; set; }
    }
}
