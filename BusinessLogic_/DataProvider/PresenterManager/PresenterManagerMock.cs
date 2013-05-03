using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.PresenterManager
{
    class PresenterManagerMock:IPresenterManager
    {
        public List<BusinessLogic.Domain.Presenter> GetAllPresenter()
        {
            throw new NotImplementedException();
        }
    }
}
