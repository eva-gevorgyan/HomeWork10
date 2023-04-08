using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Music : AudioFile
    {
        private List<AudioFile>playlist=new List<AudioFile>();
        public void AddMusic(AudioFile name)
        {
            playlist.Add(name);
            ChangeStatusEvent?.Invoke($"{name} just added to your playlist");
        }
        public void Play(AudioFile name)
        {
            ChangeStatusEvent?.Invoke($"{playlist}");
            foreach(AudioFile p in playlist)
            {
                ChangeStatusEvent?.Invoke($"{p} is playing");
            }
        }
        public delegate void ChangeStatus(string name);
        public static event ChangeStatus ChangeStatusEvent;
    }
}
