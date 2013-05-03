using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.PersonManager
{
    public class PersonManagerFactory
    {
        public IPersonManager getInstance()
        {
            return new PersonManagerMock();
        }
    }
}
