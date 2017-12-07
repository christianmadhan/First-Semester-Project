using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
  public   class Movie : NotifyChanged
    {
        
        // Description about the movie
        public string _imageUrl { get; set; }
        private string _title;
        private string _director;
        private string _length;
        private string _genre;
        private string _actors;
        private string _censorship;
        private string _description;
        

        // Constructer.
        public Movie(string imageUrl,string title, string director, string lenght, string genre, string actors, string censorship, string description)
        {
            _imageUrl = imageUrl;
            _title = title;
            _director = director;
            _length = lenght;
            _actors = actors;
            _censorship = censorship;
            _description = description;
            _genre = genre;
        }

        // Needed to add an empty contructer for the relay Command.
        public Movie() { }

        //--------------------------------------------
        // Get, Set and OnpropertyChanged
        //--------------------------------------------
      
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(Title); }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; OnPropertyChanged(Director); }
        }

        public string Length
        {
            get { return _length; }
            set { _length = value; OnPropertyChanged(Length); }
        }

        public string Actors
        {
            get { return _actors; }
            set { _actors = value; OnPropertyChanged(Actors); }
        }

        public string Censorship
        {
            get { return _censorship; }
            set { _censorship = value; OnPropertyChanged(Censorship); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(Description);}
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; OnPropertyChanged(Genre); }
        }


        /* Tostring method that return all the information
             about the movie */
        public override string ToString()
        {
            return "Title: " + Title + "\n" +
                   "Director: " + Director + "\n" +
                   "Length: " + Length + "\n" +
                   "Genre: " + Genre + "\n" +
                   "Main Actor: " + Actors + "\n" +
                   "Censorship:  " + Censorship + "\n" +
                   "Description:  " + Description;
        }
    }
}
