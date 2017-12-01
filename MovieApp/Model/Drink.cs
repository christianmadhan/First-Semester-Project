using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    class Drink : NotifyChanged
    {
        private string _name;
        private string _size;
        private int _price;

        public Drink(string name, string size, int price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        //---------------------------
        // Get and set
        //---------------------------

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(Name); }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; OnPropertyChanged(Size); }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value;  }
        }



    }
}
