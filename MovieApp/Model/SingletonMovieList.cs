using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;
using Newtonsoft.Json;

namespace MovieApp.Model
{
   public class SingletonMovieList
   {

        public static ObservableCollection<Movie> ListMovie;

        private static SingletonMovieList Instance { get; set; }

        private SingletonMovieList()
        {
            GetStaticMovieList();
            //Serilization method
            //SaveToJsonFile();
        }

        public static void GetStaticMovieList()
        {
      
            ListMovie = new ObservableCollection<Movie>()
            {
                new Movie("../Assets/strange.jpg", "Doctor Strange", "Ron Howard", "1:34:0", "ScienceFiction", "Bennidict Boi", "15+",
                    "Best movie ever",100),
                new Movie("../Assets/avatar.jpg", "Avatar", "Phil Lord", "1:23:0", "ScienceFiction", "Jennifor Anniston",
                    "15+", "Best movie ever",50),
                new Movie("../Assets/intersteller.jpg", "Intersteller", "Martin Scorsese", "1:27:0", "Action",
                    "Jennifor Anniston",
                    "15+", "Best movie ever",89),
                new Movie("../Assets/kingsman.jpg", "Kingsmen", "Christopher Nolan", "1:52:0", "Comedy", "Jennifor Anniston",
                    "15+",
                    "Best movie ever",200),
                new Movie("../Assets/Logan.jpg", "Logan", "Ron Howard", "2:50:0", "Action", "Jennifor Anniston", "18+",
                    "Best movie ever",89),
                new Movie("../Assets/nutJob2.jpg", "Nut Job 2", "Lawernce Kasdan", "1:16:0", "Animation", "Jennifor Anniston",
                    "PG",
                    "Best movie ever",89),
                new Movie("../Assets/wonder.jpg", "Wonder", "James Cameron", "1:33:0", "Documentary", "Jennifor Anniston", "18+",
                    "Best movie ever",89),
                new Movie("../Assets/insideOut.jpg", "Inside Out", "Martin Scorsese", "1:10:0", "Animation", "Jennifor Anniston",
                    "PG",
                    "Best movie ever",300),
                new Movie("../Assets/galaxy.jpg", "Gaurdians Galaxy", "Ron Howard", "2:50:0", "ScienceFiction", "Jennifor Anniston",
                    "18+",
                    "Best movie ever",150),
                new Movie("../Assets/batman1.jpg", "Batman", "Martin", "1:41:0", "Animation", "Jennifor Anniston", "PG",
                    "Best movie ever",20),
                new Movie("../Assets/bringHimHome.jpg", "The Martian", "Chris Miller", "1:50:0", "Action", "Jennifor Anniston",
                    "18+",
                    "Best movie ever",89),
                new Movie("../Assets/ninjago.jpg", "Ninjago", "Martin Scorsese", "2:50:0", "Animation", "Jennifor Anniston", "PG",
                    "Best movie ever",89),
                new Movie("../Assets/thor1.jpg", "Thor", "Ron Howard", "1:43:0", "Fantasy", "Jennifor Anniston", "18+",
                    "Best movie ever",89),
                new Movie("../Assets/superMan1.jpg", "Superman", "Lawernce Kasdan", "1:34:0", "ScienceFiction", "Jennifor Anniston",
                    "15+",
                    "Best movie ever",89),
                new Movie("../Assets/missionImpossible.jpg", "Mission Impossible", "Chris Miller", "1:14:0", "Action",
                    "Jennifor Anniston", "15+",
                    "Best movie ever",89),
                new Movie("../Assets/murderOnTheOrientExpress.jpg", "Phil Lord", "James Cameron", "2:12:0", "Action",
                    "Jennifor Anniston", "15+",
                    "Best movie ever",89),
                new Movie("../Assets/paddignton2.jpg", "Paddington", "Martin Scorsese", "2:20:0", "Animation", "Jennifor Anniston",
                    "PG",
                    "Best movie ever",89),
                new Movie("../Assets/justiceLeague.jpg", "Justice League (2017)", "Zack Snyder", "2:00:0", "ScienceFiction", "Ben Affleck",
                    "PG",
                    "Decent",89, new Uri("ms-appx:///Assets/Trailers/JusticeLeagueTrailer.mov")),
                new Movie("../Assets/MovieImage/jumanji.jpg", "Jumanji: Welcome to the Jungle", "Jake kasdan", "2:00:0", "Comedy", "Dwayne Johnson",
                    "PG",
                    "Decent",89, new Uri("ms-appx:///Assets/Trailers/jumanjiTrailer.mov"))


            };
        }

        public static SingletonMovieList GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonMovieList();
            }
            return Instance;
        }

        public void SetMovieList(ObservableCollection<Movie> listMovie)
        {
            ListMovie = listMovie;

        }

        public ObservableCollection<Movie> GetMovieList()
        {
            return ListMovie;

        }

       public void ResetMovieList()
       {
           GetStaticMovieList();
            
       }

       public void SortListPrice()
       {
           Movie x;
           for (int i = 1; i < ListMovie.Count; i++)
           for (int j = 0; j < ListMovie.Count-i; j++)
           if (ListMovie[j].Price > ListMovie[j+1].Price)
           {
               x = ListMovie[j];
               ListMovie[j] = ListMovie[j + 1];
               ListMovie[j +1] = x;
           }                                            
       }
       public void SortListAlphabetically()
       {



            Movie x;
            for (int i = 1; i < ListMovie.Count; i++)
                for (int j = 0; j < ListMovie.Count - i; j++)
                {
                    if (ListMovie[j].Title[0] > ListMovie[j + 1].Title[0])
                    {
                        x = ListMovie[j];
                        ListMovie[j] = ListMovie[j + 1];
                        ListMovie[j + 1] = x;
                    }

                    /*
                     *      DO NOT DELETE PLEASE
                     * When the first letters are same 
                     * I want it to check other letters in those words
                     */

                    //if (ListMovie[j].Title[0] == ListMovie[j+1].Title[0])
                    //{
                    //    for (int k = 1; k < ListMovie[j].Title.Length -1; k++)
                    //    {
                    //        if (ListMovie[j].Title[k] > ListMovie[j+1].Title[k])
                    //        {
                    //            x = ListMovie[j];
                    //            ListMovie[j] = ListMovie[j + 1];
                    //            ListMovie[j + 1] = x;
                    //        }
                    //    }
                    //}
                }
        }

        //public static void SaveToJsonFile()
        //{
        //    //string movieJsonString = JsonConvert.SerializeObject(ListMovie);
        //    ////var localMovieListFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("MovieData.bat", CreationCollisionOption.ReplaceExisting);
        //    ////await FileIO.WriteTextAsync(localMovieListFile, movieJsonString);

        //}
        // The file will be saved here
        //C:\Users\cmiw\AppData\Local\Packages\app.a4b445279-dd15-4c69-b3ae-cfe7278b4e9d_8wekyb3d8bbwe\LocalState
    }
}
