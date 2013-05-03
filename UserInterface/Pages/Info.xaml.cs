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
using BusinessLogic_.DataProvider.CongressManager;
using BusinessLogic.Domain;

namespace UserInterface.Pages
{
    public partial class Info : PhoneApplicationPage
    {
        public Info()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_Info_Background);
            this.PV_Info.Title = Constants.STRING_TITLE_PG_Info;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ICongressManager congressManager = CongressManagerFactory.GetInstace();
            Congress congress = congressManager.GetCongress();
            this.TB_Info.Text = congress.Info;
            this.TB_CongressName.Text = congress.Title;
            this.TB_StartAndEnd.Text = "From: " + ((DateTime)congress.StartDate).ToString("dd/MM/yyyy") + " To: " + ((DateTime)congress.EndDate).ToString("dd/MM/yyyy");
            }
    }
}