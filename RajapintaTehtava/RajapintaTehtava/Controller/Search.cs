using System;

namespace RajapintaTehtava.Search
{
    internal class Search
    {
        private string _Key; // Query needs a key to authenticate the user.
        private DateTime _Date;
        private string _searchType;

        /// <summary>
        /// Creates a Search object to contain information about search parameters
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Date"></param>
        public Search(string Key, DateTime Date)
        {
            _Key = Key;
            _Date = Date;
            _searchType = "date";
        }

        /// <summary>
        /// Creates a Search object to contain information about search parameters
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="random"></param>
        public Search(string Key, bool random = false)
        {
            _Key = Key;
            if (random) _searchType = "random";
            else _searchType = "latest";
        }

        public string Key { get => _Key; set => _Key = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public string SearchType { get => _searchType; set => _searchType = value; }
    }
}
