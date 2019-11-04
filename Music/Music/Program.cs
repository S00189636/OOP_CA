using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Program
    {
        static private Random rand = new Random();
        static void Main(string[] args)
        {
            //Q7
            Song song5 = new Song("South of the border", "ED SHEERAN");
            Song song1 = new Song("Love on the brain");
            Song song2 = new Song("ED SHEERAN", Genre.Dance);
            Song song3 = new Song("Changes","2pac",Genre.Pop,5.30);
            Song song4 = new Song("Beautiful people", "ED SHEERAN");
            
            

            List<Song> Playlist = new List<Song>();
            // Q8
            Playlist.Add(song5);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song1);

            DisplaySongs(Playlist);

            #region sorting
            //Q10
            Console.WriteLine("\n Sorting \n");
            Playlist.Sort();
            DisplaySongs(Playlist);
            #endregion

            #region shuffling

            Shuffle(Playlist);
            Console.WriteLine("\n shuffling Playlist \n");
            DisplaySongs(Playlist);
            #endregion
        }

        // Q9
        static private void DisplaySongs(List<Song> playlist)
        {
            Console.WriteLine("{0,-25}{1,-20}{2,-20}{3,-20}", "Titel", "Artist", "Genre","Duration");
            foreach (Song song in playlist)
            {
                Console.WriteLine(song.ToString());
            }
        }

        //Q11
        static private void Shuffle(List<Song> playList)
        {
            int listSize = playList.Count;
            for (int i = 0; i < listSize; i++)
            {
                int randomInt = rand.Next(i+1); // get a random number 
                Song tempSong = playList[randomInt]; 
                playList[randomInt] = playList[i]; // replace the song 
                playList[i] = tempSong; // but back the song in the playlist
            }
        }
    }
}
