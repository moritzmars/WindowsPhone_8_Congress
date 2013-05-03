using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.PresentationManager
{
    class PresentationManagerMock : IPresentationManager
    {
        public List<Domain.Presentation> GetAllPresentation()
        {
            List<Speaker> speakers = new List<Speaker>();
            speakers.Add(new Speaker
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            }); 
     
            List<Presentation> presentations = new List<Presentation>();
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 7.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 8.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 9.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 10.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 11.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 12.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 13.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 14.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            presentations.Add(new Presentation { Title = "Evolution of the implementation in .NET 15.0", speaker = speakers, StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2) });
            return presentations; 
        }
    }
}
