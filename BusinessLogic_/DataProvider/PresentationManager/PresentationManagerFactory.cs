using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.PresentationManager
{
    public class PresentationManagerFactory
    {
        public static IPresentationManager GetInstance()
        {
            return new PresentationManagerMock();
        }
    }
}
