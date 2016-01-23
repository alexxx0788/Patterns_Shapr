using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.structure
{
    class AudioToVideoAdapter:IVideoPlayer
    {
        private IAudioPlayer _audioPlayer;
        public AudioToVideoAdapter(IAudioPlayer audioPlayer)
        {
            _audioPlayer = audioPlayer;
        }
        public void LoadVideo()
        {
            _audioPlayer.LoadAudio();
        }
    }
}
