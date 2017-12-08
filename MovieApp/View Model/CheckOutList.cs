using MovieApp.Model;

namespace MovieApp.View_Model
{
    class CheckOutList
    {
        //Selected Food



        // Selected Movie
        private Singleton _singleton;

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public CheckOutList()
        {
            _singleton = Singleton.GetInstance();

            ImageUrl = _singleton.GetImageUrl();
            Title = _singleton.GetTitle();
            Price = _singleton.GetPrice();



        }

    }
}
