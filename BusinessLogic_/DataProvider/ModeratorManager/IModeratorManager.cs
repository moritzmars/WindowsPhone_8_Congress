using BusinessLogic.Configuration;
using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_.DataProvider.ModeratorManager
{
    public interface IModeratorManager
    {
        List<Moderator> GetAllModerators(); 
    }
}
