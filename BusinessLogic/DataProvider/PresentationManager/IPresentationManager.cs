using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.PresentationManager
{
    public interface IPresentationManager
    {
        public List<Presentation> GetAllPresentation();

    }
}
