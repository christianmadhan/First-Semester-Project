using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
     class Movie : NotifyChanged
    {
        
        // Description about the movie
        public string _title;
        public string _instructor;
        public string _length;
        public string _actors;
        public string _censorship;
        public string _description;
        public string _premiereDate;

        // Constructer.
        public Movie(string title, string instructor, string lenght, string actors, string censorship, string description,
            string premiereDate)
        {
            _title = title;
            _instructor = instructor;
            _length = lenght;
            _actors = actors;
            _censorship = censorship;
            _description = description;
            _premiereDate = premiereDate;
        }

        //--------------------------------------------
        // Get, Set and OnpropertyChanged
        //--------------------------------------------

        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(Title); }
        }

        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; OnPropertyChanged(Instructor); }
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

        public string PremiereDate
        {
            get { return _premiereDate; }
            set { _premiereDate = value; OnPropertyChanged(PremiereDate); }
        }



        /* Tostring method that return all the information
             about the movie */
        public override string ToString()
        {
            return "Title: " + Title + "\n" +
                        "Instructor: " + Instructor + "\n" +
                        "Length: " + Length + "\n" +
                        "Actors: " + Actors + "\n" +
                       "Censorship:  " + Censorship + "\n" +
                       "Description:  " + Description + "\n" +
                       "Premiere Date: " + PremiereDate;
        }
    }
}
