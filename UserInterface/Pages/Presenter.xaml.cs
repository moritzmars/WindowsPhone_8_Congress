using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BusinessLogic.DataProvider.PersonManager;
using BusinessLogic.Helper;
using BusinessLogic.Domain;
using BusinessLogic.Configuration;

namespace UserInterface.Pages
{
    public partial class Presenter : PhoneApplicationPage
    {
        public Presenter()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_Presenter_Background);
            this.PV_Presenter.Title = Constants.STRING_TITLE_PG_Presenter;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IPersonManager personManager = PersonManagerFactory.GetInstance();
            List<Person> persons = personManager.GetAllPersons();
            List<AlphaKeyGroup<Person>> personCategoryGrp = AlphaKeyGroup<Person>.CreateGroups(persons, System.Threading.Thread.CurrentThread.CurrentUICulture, (Person person) => { return person.LastName; }, true);
            this.LLS_Presenters.ItemsSource = personCategoryGrp;

        }

        private void LLS_Presenters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person selectedPerson = (Person)e.AddedItems[0]; 
            NavigationService.Navigate(new Uri(String.Format("/Pages/PresenterDetail.xaml?ID={0}", selectedPerson.ID), UriKind.RelativeOrAbsolute));
        }
    }
}