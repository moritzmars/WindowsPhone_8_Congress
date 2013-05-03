using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.CongressManager
{
    public class CongressManagerFactory
    {
        public static ICongressManager GetInstace()
        {
            return new CongressManagerMock(); 
        }

    }
}
