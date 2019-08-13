using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    public class Song
    {
        public string title;
        public string artist;
        public int year;
        public Song nextSong;

        public Song(string t, string a, int y)
        {
            this.title = t;
            this.artist = a;
            this.year = y;
        }

        public void PlaySong()
        {
            Console.WriteLine("Playing song " + title + " by " + artist + " " +  year);
        }
    }
}
