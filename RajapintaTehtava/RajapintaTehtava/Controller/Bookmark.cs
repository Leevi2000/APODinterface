using System;

namespace RajapintaTehtava.Controller
{
    internal class Bookmark
    {
        /// <summary>
        /// Create a bookmark object.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        public Bookmark(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public string Name { get; set; }
        public DateTime Date { get; set; }

    }
}
