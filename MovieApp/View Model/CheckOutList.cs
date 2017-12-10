using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using MovieApp.Model;

namespace MovieApp.View_Model
{
    class CheckOutList
    {
        //Selected Food
        private singletonFood _singletonFood;
        
        public string NameFood { get; set; }

        public string SizeFood { get; set; }

        public int PriceFood { get; set; }


        // Selected Movie
        private singletonMovie _singleton;

        public string ImageUrlMovie { get; set; }

        public string TitleMovie { get; set; }

        public int PriceMovie { get; set; }

        // Download The Text as pdf

         public RelayCommand GetTicket { get; set; }

        public int TotalPrice { get; set; }

        public CheckOutList()
        {
            _singleton = singletonMovie.GetInstance();
            _singletonFood = singletonFood.GetInstance();


            NameFood = _singletonFood.GetName();
            SizeFood = _singletonFood.GetSize();
            PriceFood = _singletonFood.GetPrice();

            ImageUrlMovie = _singleton.GetImageUrl();
            TitleMovie = _singleton.GetTitle();
            PriceMovie = _singleton.GetPrice();

            TotalPrice = PriceMovie + PriceFood;

            GetTicket = new RelayCommand(DownloadTicket);
        }

        public async void DownloadTicket()
        {
            FileSavePicker picker = new FileSavePicker();
            picker.FileTypeChoices.Add("txt", new List<string>() { ".txt" });
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.SuggestedFileName = "RuybyTicket";
 
            StorageFile file = await picker.PickSaveFileAsync();
            if (file != null)
            {
                int totalPrice = _singleton.GetPrice() + _singletonFood.GetPrice();
                StringBuilder builder = new StringBuilder();
                string information;
                
                if (_singletonFood.GetName() == "")
                {
                    information = "Movie: " + _singleton.GetTitle() + "Price: " + _singleton.GetPrice();
                }
                else
                {
                    information = "Movie: " + _singleton.GetTitle() + "Price: " + _singleton.GetPrice() + "Food: " +
                                  _singletonFood.GetName() + "Total price: " + totalPrice;

                }
               
                await FileIO.WriteTextAsync(file, information);
            }


        }

    }
}
