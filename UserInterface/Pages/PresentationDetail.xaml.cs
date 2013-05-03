using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BusinessLogic.DataProvider.PresentationManager;
using BusinessLogic.Domain;
using BusinessLogic.Configuration;
using BusinessLogic.Helper;

namespace UserInterface.Pages
{
    public partial class PresentationDetail : PhoneApplicationPage
    {
        public PresentationDetail()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_PresentationDetail_Background);
            this.PV_PresentationDetail.Title = Constants.STRING_TITLE_PG_PresentationDetail;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            String queryID = "";
            int presentationID = 0; 
            if (NavigationContext.QueryString.TryGetValue("ID", out queryID))
            {
                presentationID = int.Parse(queryID);

            }
            IPresentationManager presentationManager = new PresentationManagerMock();
            Presentation presentation = presentationManager.GetPresentationByID(new Presentation { ID = presentationID });
            if (presentation == null)
                return;
            this.TB_PresentationName.Text = presentation.Title;
            this.TB_PresentationAbstract.Text = presentation.Abstract;
            this.TB_PresentationTime.Text = presentation.StartDateTime.ToString(); 
            this.TB_PresentationType.Text = presentation.Type;

        }
    }
}