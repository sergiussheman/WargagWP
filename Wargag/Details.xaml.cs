using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Wargag.Model;
using Newtonsoft.Json;

namespace Wargag
{
    public partial class Details : PhoneApplicationPage
    {
        string currentURLRequest;
        MainRootComments mainRootComments;
        List<CommentObject> tempComments;
        List<CommentObject> comments = new List<CommentObject>();
       
        public Details()
        {
            InitializeComponent();
            LoadInfo();

        }

        public void LoadInfo()   //выполнение запроса для скачивания информации с сайта
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;
            currentURLRequest = UtilityClass.URLCommentsRequest;
            currentURLRequest += "253388";
            webClient.DownloadStringAsync(new Uri(currentURLRequest));
        }

        private void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Result))
            {
                mainRootComments = JsonConvert.DeserializeObject<MainRootComments>(e.Result); //парсинг полученного ответа

                tempComments = mainRootComments.data;
                ParsingAnswer();
            }
        }

        private void ParsingAnswer()
        {
            List<Datum> tempQuotes = new List<Datum>();
            List<Datum> tempPictures = new List<Datum>();

            foreach (var item in tempComments)
            {
                //конвертация даты в более понятный формат;
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(item.created_at).ToUniversalTime();
                item.time_created = dtDateTime.ToString();//полученная дата хранится в отдельном поле

                comments.Add(item);

            }
            listSelector.ItemsSource = this.comments;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Datum tempQuote = App.transferDatum;
            this.btnRating.Content = tempQuote.rating.ToString();
            this.txtDescription.Text = tempQuote.description;
            this.txtNickName.Text = tempQuote.nickname;
            this.txtTimeCreated.Text = tempQuote.time_created;
            base.OnNavigatedTo(e);
        }
    }
}