using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    // Q2
    class Song   : IComparable
    {
        // Q4
        public string Titel { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }
        public double Duration { get; set; }

        #region constructors

        // Q5
        public Song(string titel, string artist,Genre genre, double duration)
        {
            Titel = titel;
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }

        public Song(string title) : this(title, "Unknown",Genre.Other, 0) { }
        public Song(string title,Genre genre) : this(title, "Unknown",genre, 0) { }
        public Song(string title, string artist) : this(title, artist, Genre.Other, 0.0) { }
        #endregion

        //Q6
        public override string ToString()
        {
            return String.Format("{0,-25}{1,-20}{2,-20}{3,-20}",Titel,Artist,Genre.ToString(),Duration.ToString());
        }
        //Q10
        public int CompareTo(object obj)
        {
            int result;
            Song song = obj as Song;
            result = Artist.CompareTo(song.Artist);
            if (result == 0)
                result = Titel.CompareTo(song.Titel);
            return result;
        }
    }


    public enum Genre // Q3
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
