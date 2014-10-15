using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Wargag.Model;

namespace Wargag
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (sort.IsOpen)
                sort.IsOpen = false;
            else
                sort.IsOpen = true;
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //string s = "jkj";
           // string myText = new TextRange(transcriberArea.Document.ContentStart, transcriberArea.Document.ContentEnd).Text; 
            ((RichTextBox)sender).SelectAll();
            string description = ((RichTextBox)sender).Selection.Text;
            Datum tempQuote =  App.ViewModel.findQuote(description);

            App.transferDatum = tempQuote;
            string destination = "/Details.xaml";
            NavigationService.Navigate(new Uri(destination, UriKind.Relative));
        }

        private void RichTextBox_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            String nickname = ((TextBlock)sender).Text;
        }
    }
}