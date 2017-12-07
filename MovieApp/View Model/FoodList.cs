﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Model;

namespace MovieApp.View_Model
{
    class FoodList : NotifyChanged
    {
        /* 
         The Name FoodList may be wrong in this context
         Change it or dont, it works!
        */

        private Food _seleceteFood;

        private readonly FrameNavigate _frameNavigate;

        private SingleTonFoodList _singleFood = SingleTonFoodList.GetInstance();

        public ObservableCollection<Food> Foods { get; set; }

        public RelayCommand AddFood { get; set; }

        public RelayCommand DeleteFood { get; set; }

        public RelayCommand GoToCheckOutCommand { get; set; }

        public Food AddNewFood { get; set; }

        // Will be implemented.
        //public Food SelectedFood
        //{
        //    get => _seleceteFood;
        //    set
        //    {
        //        _seleceteFood = value;
        //        OnPropertyChanged(SelectedFood);
        //    }
        //}

    //-----------------------------------------------------------------
    // Retrive Selected Movie Item and display,
        private Singleton _singleton;

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Lenght { get; set; }

        public string Genre { get; set; }

        public string Actors { get; set; }

        public string Censorship { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public FoodList()
        {
            _singleton = Singleton.GetInstance();

            ImageUrl = _singleton.GetImageUrl();
            Title = _singleton.GetTitle();
            Director = _singleton.GetDirector();
            Lenght = _singleton.GetLength();
            Genre = _singleton.GetGenre();
            Actors = _singleton.GetActors();
            Censorship = _singleton.GetCensorship();
            Description = _singleton.GetDescription();
            Price = _singleton.GetPrice();

            try
            {
                Foods = new ObservableCollection<Food>();

                var foodList = _singleFood.GetFoodList();

                Foods = foodList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        //-----------------------------------------------------------------
    }
}
