using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    public class PlayList
    {
        Song head;
        Song tail;

        public PlayList(Song head)
        {
            this.head = head;
            this.tail = head;
        }

        public void AddSong(Song song)
        {
            tail.nextSong = song;
            tail = song;
        }

        

        public void Play()
        {
            Song currentSong = head;

            while(currentSong != null)
            {
                currentSong.PlaySong();
                currentSong = currentSong.nextSong;
            }
        }

        public void InsertSong()
        {

        }

    }
}
