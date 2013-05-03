using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BusinessLogic.DataProvider;
using BusinessLogic.DataProvider.PersonManager;
using BusinessLogic.Domain;
using BusinessLogic.DataProvider.PresentationManager;
using BusinessLogic.Configuration;
using BusinessLogic.Helper; 

namespace UserInterface.Pages
{
    public partial class PresenterDetail : PhoneApplicationPage
    {
        public PresenterDetail()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_PresenterDetail_Background);
            this.PV_PresenterDetail.Title = Constants.STRING_TITLE_PG_PresenterDetail;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            String queryID = "";
            int personID = 0; 
            if (NavigationContext.QueryString.TryGetValue("ID", out queryID))
            {
               personID = int.Parse(queryID);
               
            }
            IPersonManager personManager = PersonManagerFactory.GetInstance();
            Person person = personManager.GetPersonByID(new Person { ID = personID });
            if(person.Title != String.Empty)
            this.TB_PersonName.Text = person.Title + " " + person.FirstName + " " + person.LastName;
            else
                this.TB_PersonName.Text = person.FirstName + " " + person.LastName;
          
            this.TB_PersonUniversity.Text = person.University;
            this.TB_PersonCityAndCountry.Text = person.City + ", " + person.Country;
            
            Speaker filterSpeaker = new Speaker(); 
            filterSpeaker.ID = person.ID; 

            IPresentationManager presentationManager = PresentationManagerFactory.GetInstance();
            this.LLS_Presentations.ItemsSource = presentationManager.GetPresentationBySpeaker(filterSpeaker); 
            

        }

        private void LLS_Presentations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Presentation selectedPresentation = (Presentation)e.AddedItems[0];
            NavigationService.Navigate(new Uri(String.Format("/Pages/PresentationDetail.xaml?ID={0}", selectedPresentation.ID), UriKind.RelativeOrAbsolute));
        }
       
    }
}