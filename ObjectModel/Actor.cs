using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Actor
    {
        #region Constructor
        /// <summary>
        /// Default Empty Constructor
        /// </summary>
        public Actor() 
        {
            _actorId = ActorId;
            _actorName = ActorName;
            _actorLastName = ActorLastName;
            _movieId = MovieId;
        }
        #endregion
        #region Private Fields
        private int _actorId;
        private string _actorName;
        private string _actorLastName;
        private int _movieId;
        #endregion
        #region Public Properties
        public int ActorId
        {
            get { return _actorId; }
            set { _actorId = value; }
        }
        public string ActorName
        {
            get { return _actorName; }
            set { _actorName = value; }
        }
        public string ActorLastName
        {
            get { return _actorLastName; }
            set { _actorLastName = value; }
        }

        public int MovieId
        {
            get { return _movieId; }
            set { _movieId = value; }
        }
        public virtual Movie Movie
        {
            get;
            set;
        }
        #endregion
        
    }
}
