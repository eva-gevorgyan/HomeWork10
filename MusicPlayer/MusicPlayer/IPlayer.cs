using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal interface IPlayer
    {
        void Play(AudioFile name);
        void Stop(AudioFile name);
    }
}
