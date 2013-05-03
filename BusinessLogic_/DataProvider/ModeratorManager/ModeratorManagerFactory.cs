using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.ModeratorManager
{
    public class ModeratorManagerFactory
    {
        public static IModeratorManager GetInstance()
        {
            return new ModeratorManagerMock();
        }
    }
}
