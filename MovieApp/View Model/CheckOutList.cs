using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using MovieApp.Model;
using MovieApp.View;

namespace MovieApp.View_Model
{
    class CheckOutList
    {
        private readonly FrameNavigate _frameNavigate;
       
        //Selected Food
        private singletonFood _singletonFood;
        
        public string NameFood { get; set; }

        public string SizeFood { get; set; }

        public int PriceFood { get; set; }

        public string PromoCode { get; set; }

        // Selected Movie
        private singletonMovie _singleton;

        public string ImageUrlMovie { get; set; }

        public string TitleMovie { get; set; }

        public int PriceMovie { get; set; }

        

        // Download The Text as pdf

        public RelayCommand GetTicket { get; set; }

        public double TotalPrice { get; set; }

        public CheckOutList()
        {
            TotalPrice = PriceMovie + PriceFood;

            _singleton = singletonMovie.GetInstance();
            _singletonFood = singletonFood.GetInstance();
            _frameNavigate = new FrameNavigate();


            NameFood = _singletonFood.GetDescription();
            SizeFood = _singletonFood.GetSize();
            PriceFood = _singletonFood.GetPrice();
            ImageUrlMovie = _singleton.GetImageUrl();
            TitleMovie = _singleton.GetTitle();
            PriceMovie = _singleton.GetPrice();
            if (String.IsNullOrEmpty(_singletonFood.GetPromoCode()))
            {
                PromoCode = "No promocode";
                TotalPrice = PriceMovie + PriceFood;
            }
            else if (_singletonFood.GetPromoCode().Equals("1forrest1", StringComparison.CurrentCultureIgnoreCase))
            {
                double price = _singleton.GetPrice() + _singletonFood.GetPrice();
                double Saving = 0.20 * price;
                PromoCode = _singletonFood.GetPromoCode();
                TotalPrice = price - Saving;
            }
            else
            {
                PromoCode = "Not valid";
            }
            

            GetTicket = new RelayCommand(DownloadTicket);
        }

        public async void DownloadTicket()
        {
        
            Random random = new Random();
            FileSavePicker picker = new FileSavePicker();
            picker.FileTypeChoices.Add("RTF", new List<string>() { ".RTF" });
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.SuggestedFileName = "RuybyTicket";

           
 
            StorageFile file = await picker.PickSaveFileAsync();
            if (file != null)
            {
              
                string Rubyticket = "                   Ruby Ticket" + Environment.NewLine;
                string dodedLine = "---------------------------------------------------" + Environment.NewLine;
                string  movieinformation = "Movie: " + _singleton.GetTitle() + Environment.NewLine + "Price: " + _singleton.GetPrice() + Environment.NewLine + Environment.NewLine;
                string foodinformation = "Food: " + _singletonFood.GetDescription() + Environment.NewLine + "Price: " + _singletonFood.GetPrice() + Environment.NewLine + Environment.NewLine;
                string totalPrice = "Total Price " + TotalPrice + Environment.NewLine + Environment.NewLine;
                string promocode = "Promocode: " + PromoCode + Environment.NewLine + Environment.NewLine;
                string important = "! Important ! " + Environment.NewLine;
                string ticketID = "Ticket ID:  " + random.Next(1, 10000) + Environment.NewLine;
                string print = "Print this document, and show it" + Environment.NewLine +
                               "In our theater, and you will" + Environment.NewLine + "get your menu and tickets" + Environment.NewLine + Environment.NewLine;
                string goodbuy = "We look forward seeing you!";




                StringBuilder builder = new StringBuilder();
                builder.AppendLine(Rubyticket + dodedLine + movieinformation +  foodinformation + promocode + totalPrice + dodedLine + important + ticketID + dodedLine + print + goodbuy );
                
               
                await FileIO.WriteTextAsync(file, builder.ToString());

                var dialog = new MessageDialog("You have Succesfully Downloaded the ticket!" + Environment.NewLine + "You will now get returned to the home page");
                await dialog.ShowAsync();

                Type type = typeof(MainPage);
                _frameNavigate.ActivateFrameNavigation(type);

            }


        }

    }
}
