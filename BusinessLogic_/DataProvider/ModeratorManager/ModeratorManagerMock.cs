using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.ModeratorManager
{
    public class ModeratorManagerMock:IModeratorManager
    {
        public List<BusinessLogic.Domain.Moderator> GetAllModerators()
        {
            throw new NotImplementedException();
        }
    }
}
