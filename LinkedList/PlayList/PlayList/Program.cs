using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Chinna Chinna Aasai", "A.R.R", 1992);
            PlayList myPlayList = new PlayList(song1);

            

            Song song2 = new Song("Antha Arabic Kadaloram", "A.R.R", 1994);
            myPlayList.AddSong(song2);
            //song2.PlaySong();
            Song song3 = new Song("Margazhi Poove", "A.R.R", 1996);
            myPlayList.AddSong(song3);

            Song song4 = new Song("Malargal Kettaen", "A.R.R", 2016);
            myPlayList.AddSong(song4);
            myPlayList.Play();
        }
    }
}
