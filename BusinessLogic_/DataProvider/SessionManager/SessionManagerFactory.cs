using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.SessionManager
{
    public class SessionManagerFactory
    {
        public static ISessionManager GetInstance()
        {
            return new SessionManagerMock();
        }
    }
}
