using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    class SingleTonFoodList
    {
        private static ObservableCollection<Food> ListFood;

        private static SingleTonFoodList Instance { get; set; }

        private SingleTonFoodList()
        {
            GetStaticFoodList();
        }

        private void GetStaticFoodList()
        {
            ListFood = new ObservableCollection<Food>()
            {
                new Food("../Assets/food.png","Menu 1", "Large", 100),
                new Food("../Assets/food.png","Menu 2", "Medium", 50),
                new Food("../Assets/food.png","Menu 3", "Small", 60),
                new Food("../Assets/food.png","Menu 4", "Large", 80),
                new Food("../Assets/food.png","Menu 5", "XXLARGE REST IN PEACE", 90),
            };
        }

        public static SingleTonFoodList GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingleTonFoodList();
            }
            return Instance;
        }

        public void SetFoodLust(ObservableCollection<Food> listFood)
        {
            ListFood = listFood;
        }

        public ObservableCollection<Food> GetFoodList()
        {
            return ListFood;
        }
    }
}
