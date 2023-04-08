using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    abstract class AudioFile:IPlayer
    {
        public string name { get; set; }
        public void Play(AudioFile name)
        {
            Console.WriteLine($"Play {name}");
        }
        public void Stop(AudioFile name) {
            Console.WriteLine($"{name} stopped!");
        }
    }
}
