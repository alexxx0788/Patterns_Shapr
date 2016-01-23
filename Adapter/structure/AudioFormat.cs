using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.structure
{
    class AudioFormat:IAudioPlayer
    {
        public string _name;

        public AudioFormat(string name)
        {
            _name = name;
        }
        public void LoadAudio()
        {
            Console.WriteLine(string.Format("Loading audio {0}",_name));
        }
    }
}
