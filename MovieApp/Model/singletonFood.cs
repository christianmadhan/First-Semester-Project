using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    class singletonFood
    {
        public static Food _food;

        private static singletonFood Instance { get; set; }

        private singletonFood()
        {
            _food = new Food();
        }

        public static singletonFood GetInstance()
        {
            if (Instance == null)
            {
                Instance = new singletonFood();
            }
            return Instance;
        }

        public void SetFood(Food food)
        {
            _food = food;
        }

        public string GetImageUrl()
        {
            return _food.ImageUrl;
        }

        public string GetName()
        {
            return _food.Name;
        }

        public string GetSize()
        {
            return _food.Size;
        }

        public int GetPrice()
        {
            return _food.Price;
        }

        public string GetDescription()
        {
            return _food.Description;
        }


    }
}
