using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.PresenterManager
{
    public class PresenterManagerFactory
    {
        public static IPresenterManager GetInstance()
        {
            return new PresenterManagerMock();
        }
    }
}
