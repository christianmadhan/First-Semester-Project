using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using MovieApp.Model;
using MovieApp.View;

namespace MovieApp.View_Model
{
    class FoodList : NotifyChanged
    {
        /* 
         The Name FoodList may be wrong in this context
         Change it or dont, it works!
        */

        private Food _selecetedFood;
        

        private readonly FrameNavigate _frameNavigate;

        private readonly singletonFood _userSingletonFood;

        private SingleTonFoodList _singleFood = SingleTonFoodList.GetInstance();

        public ObservableCollection<Food> Foods { get; set; }

        public RelayCommand AddFood { get; set; }

        public RelayCommand DeleteFood { get; set; }

        public RelayCommand GoToCheckOutCommand { get; set; }

        public Food AddNewFood { get; set; }

       
        public Food SelectedFood
        {
            get => _selecetedFood;
            set
            {
                _selecetedFood = value;
                OnPropertyChanged(nameof(SelectedFood));
            }
        }

        //-----------------------------------------------------------------
        // Retrive Selected Movie Item and display,
        private singletonMovie _singleton;

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Lenght { get; set; }

        public string Genre { get; set; }

        public string Actors { get; set; }

        public string Censorship { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Uri Trailer { get; set; }

        public FoodList()
        {
            _singleton = singletonMovie.GetInstance();

            ImageUrl = _singleton.GetImageUrl();
            Title = _singleton.GetTitle();
            Director = _singleton.GetDirector();
            Lenght = _singleton.GetLength();
            Genre = _singleton.GetGenre();
            Actors = _singleton.GetActors();
            Censorship = _singleton.GetCensorship();
            Description = _singleton.GetDescription();
            Price = _singleton.GetPrice();
            Trailer = _singleton.GetTrailer();

            try
            {
                Foods = new ObservableCollection<Food>();

                var foodList = _singleFood.GetFoodList();

                Foods = foodList;
            }
            catch (Exception e)
            {
                var dialig = new MessageDialog(e.Message);

            }

            AddFood = new RelayCommand(DoAddFood);
            DeleteFood = new RelayCommand(DoDeleteFood);
            GoToCheckOutCommand = new RelayCommand(DoGoToCheckout);

            AddNewFood = new Food();

            SelectedFood = new Food();

            _frameNavigate = new FrameNavigate();

            _userSingletonFood = singletonFood.GetInstance();
        }

        public void DoAddFood()
        {
            
        }

        public void DoDeleteFood()
        {
            
        }

        public void DoGoToCheckout()
        {
            _userSingletonFood.SetFood(_selecetedFood);
            Type type = typeof(CheckOutPage);
            _frameNavigate.ActivateFrameNavigation(type);

        }
        //-----------------------------------------------------------------
    }
}
