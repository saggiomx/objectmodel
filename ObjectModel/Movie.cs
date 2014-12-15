using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Movie
    {
        #region Constructor Fields
        public Movie() 
        {
            _movieId = MovieId;
            _movieName = MovieName;
        }
        #endregion
        #region Private Fields
        private int _movieId;
        private string _movieName;

        #endregion
        #region Public Properties
        public int MovieId 
        {
            get { return _movieId; }
            set { _movieId = value; }
        }
        public string MovieName 
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        public virtual List<Actor> Actors
        {
            get;
            set;
        }
        #endregion

    }
}
