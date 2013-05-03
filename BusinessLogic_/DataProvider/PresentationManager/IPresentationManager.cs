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
        List<Presentation> GetAllPresentation();
        List<Presentation> GetPresentationBySpeaker(Speaker speaker);
        Presentation GetPresentationByID(Presentation presentation); 
    }
}
