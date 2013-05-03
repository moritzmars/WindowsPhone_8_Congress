using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Globalization;
using BusinessLogic.Helper;
using BusinessLogic.Configuration;

namespace UserInterface.Pages
{
    public partial class Main : PhoneApplicationPage
    {
        public Main()
        {
            InitializeComponent();
            this.LayoutRoot.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_PG_Main_Background);
            this.PV_Main.Title = Constants.STRING_TITLE_PG_Main;
        }

        private void BT_Schedule_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Schedule.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BT_Presenter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Presenter.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BT_Info_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Info.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BT_Search_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Search.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BT_Search_Loaded(object sender, RoutedEventArgs e)
        {
            this.BT_Info.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_BT_Info_Background);
            this.BT_Schedule.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_BT_Schedule_Background);
            this.BT_Presenter.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_BT_Presenter_Background);
            this.BT_Search.Background = ColorFactory.GetColorFromHex(Constants.HEX_COLOR_BT_Search_Background);
        }

    }
}