using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BusinessLogic.Configuration;
using BusinessLogic.Helper;
using BusinessLogic_.DataProvider.PresenterManager;
using BusinessLogic.DataProvider.PresentationManager;

namespace UserInterface.Pages
{
    public partial class Search : PhoneApplicationPage
    {
        public Search()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_Search_Background);
            //this.PV_Search.Title = Constants.STRING_TITLE_PG_Search;
            IPresentationManager presenterManager = PresentationManagerFactory.GetInstance();
            this.LLS_Search.ItemsSource = presenterManager.GetAllPresentation(); 
           
        }

        private void LLS_Presenters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}