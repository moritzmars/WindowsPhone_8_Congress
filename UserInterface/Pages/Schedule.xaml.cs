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
using BusinessLogic.DataProvider.PresentationManager;
using BusinessLogic.Domain;

namespace UserInterface.Pages
{
    public partial class Schedule : PhoneApplicationPage
    {
        public Schedule()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_Schedule_Background);
            this.PV_Schedule.Title = Constants.STRING_TITLE_PG_Schedule;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IPresentationManager presentationManager = PresentationManagerFactory.GetInstance();
            List<Presentation> presentations = presentationManager.GetAllPresentation();
                  
            foreach (Presentation presentation in presentations)
            {
                if ((this.PV_Schedule.Items.Where(currentPivotItem => ((PivotItem)currentPivotItem).Header == ((DateTime)presentation.StartDateTime).DayOfWeek.ToString())).Count<Object>() == 0)
                {
                    switch (((DateTime)presentation.StartDateTime).DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            this.PVI_ScheduleMonday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleMonday.Visibility = Visibility.Visible;
                            break;
                        case DayOfWeek.Tuesday:
                            this.PVI_ScheduleTuesday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleTuesday.Visibility = Visibility.Visible;
                            break;
                        case DayOfWeek.Wednesday:
                            this.PVI_ScheduleWednesday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleWednesday.Visibility = Visibility.Visible;
                            break;
                        case DayOfWeek.Thursday:
                            this.PVI_ScheduleThursday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleThursday.Visibility = Visibility.Visible;
                            break;
                        case DayOfWeek.Friday:
                            this.PVI_ScheduleFriday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleFriday.Visibility = Visibility.Visible;
                            break;
                        case DayOfWeek.Saturday:
                            this.PVI_ScheduleSaturday.Header = ((DateTime)presentation.StartDateTime).DayOfWeek.ToString();
                            this.PVI_ScheduleSaturday.Visibility = Visibility.Collapsed;
            
                            break;
                        case DayOfWeek.Sunday:

                            break;

                    }
                }


            }
            foreach (PivotItem item in this.PV_Schedule.Items.ToList())
            {
                if (item.Visibility == Visibility.Collapsed)
                    this.PV_Schedule.Items.Remove(item);
            }
        }
        private void PV_Schedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IPresentationManager presentationManager = PresentationManagerFactory.GetInstance();
            List<Presentation> presentations = presentationManager.GetAllPresentation();
            List<Presentation> filteredPresentations = (presentations.Where(currentPresentation => ((DateTime)currentPresentation.StartDateTime).DayOfWeek.ToString() == ((PivotItem)this.PV_Schedule.SelectedItem).Header)).ToList<Presentation>();
           
            //List<AlphaKeyGroup<Presentation>> presentationCategoryGrp = AlphaKeyGroup<Presentation>.CreateGroups(filteredPresentations, System.Threading.Thread.CurrentThread.CurrentUICulture, (Presentation person) => { return person.Title; }, true);

            if (filteredPresentations.Count == 0)
                return; 
            switch (((DateTime)filteredPresentations[0].StartDateTime).DayOfWeek)
            {
                case DayOfWeek.Monday:
                    this.LLS_ScheduleMondayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Tuesday:
                    this.LLS_ScheduleTuesdayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Wednesday:
                    this.LLS_ScheduleWednesdayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Thursday:
                    this.LLS_ScheduleThursdayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Friday:
                    this.LLS_ScheduleFridayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Saturday:
                    this.LLS_ScheduleSaturdayPresentation.ItemsSource = filteredPresentations;
                    break;
                case DayOfWeek.Sunday:
                    //this.LLS_ScheduleSundayPresentation.ItemsSource = presentationCategoryGrp;
                    break;

            }

            //foreach (Presentation currentPresentation in presentations)
            //{
            //    this.LLS_ScheduleFridayPresentation.ItemsSource.Add(currentPresentation);
            // }
            //this.PV_Schedule.ItemsSource = null; 
            //this.PV_Schedule.ItemsSource = presentations;


        }
        private void LLS_Schedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Presentation selectedPresentation = (Presentation)e.AddedItems[0];
            NavigationService.Navigate(new Uri(String.Format("/Pages/PresentationDetail.xaml?ID={0}", selectedPresentation.ID), UriKind.RelativeOrAbsolute));
 
        }
    }
}