using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.SessionManager
{
    public class SessionManagerMock:ISessionManager
    {
        public List<Domain.Session> GetAllSession()
        {
            List<Moderator> moderators = new List<Moderator>();
            moderators.Add(new Moderator {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            
            }); 

            List<Session> sessions = new List<Session>();
            sessions.Add(new Session { EndDateTime = DateTime.Now.AddDays(3), StartDateTime = DateTime.Now, Room = "Auditorium", SessionType = "Discussion", moderators = moderators });
            return sessions; 
        }
    }
}
